using ClassicRigorAPI.Dto;
using ClassicRigorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClassicRigorAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClientService _clientService;

    public ClienteController(ClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpPost]
    public IActionResult CadastraCliente([FromBody] ClienteDto cliente)
    {
        try
        {
            string resultado = _clientService.CadastrarCliente(cliente);
            if (resultado.Contains("CPF")) return BadRequest(resultado);
            return CreatedAtAction("CadastraCliente", resultado);
        }catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
