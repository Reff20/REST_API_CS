using ClassicRigorAPI.Data;
using ClassicRigorAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectDb = builder.Configuration.GetConnectionString("ClassicConnection");

builder.Services.AddDbContext<ClientContext>(opt => opt.UseMySql(connectDb, ServerVersion.AutoDetect(connectDb)));
builder.Services.AddScoped<ClientService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
