using ClassicRigorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassicRigorAPI.Data;

public class ClientContext : DbContext
{
    public DbSet<Clientes> Cliente { get; set; }
    public ClientContext(DbContextOptions<ClientContext> options) : base(options)
    {
        
    }
}
