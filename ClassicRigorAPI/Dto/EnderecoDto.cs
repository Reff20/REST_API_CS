namespace ClassicRigorAPI.Dto;

public class EnderecoDto
{
    public string Cep { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public int Numero { get; set; }
    public string Cidade { get; set; }
    public string? Complemento { get; set; }
}
