using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassicRigorAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo CEP é obrigatório...")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo RUA é obrigatório...")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "O campo BAIRRO é obrigatório...")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo NÚMERO é obrigatório...")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "O campo CIDADE é obrigatório...")]
        public string Cidade { get; set; }
        public string? Complemento { get; set; }

    }
}
