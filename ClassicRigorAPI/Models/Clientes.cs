using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassicRigorAPI.Models;

public class Clientes
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo NOME é obrigatório...")]
    [StringLength(4)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo SOBRENOME é obrigatório...")]
    [StringLength(4)]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório...")]
    [StringLength(14)]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O campo RG é obrigatório...")]
    [StringLength(12)]
    public string Rg { get; set; }

    [Required(ErrorMessage = "O campo DATA DE NASCIMENTO é obrigatório...")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O campo NÚMERO DE TELEFONE é obrigatório...")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "É necessário saber se o TELEFONE está vinculado com um WHATSAPP...")]
    public bool isWpp { get; set; }

    public string? Email { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o ENREDEÇO")]
    public Endereco Endereco { get; set; }
}
