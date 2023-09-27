namespace ClassicRigorAPI.Dto;

public class ClienteDto
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public DateTime DtNasc { get; set; }
    public EnderecoDto Endereco { get; set; }
    public string Telefone { get; set; }
    public bool WhatsApp { get; set; }
    public string? Email { get; set; }
}
