using System.ComponentModel.DataAnnotations;

namespace SenaiMvc.Models.Escola
{
	public class EnderecoModel
	{
        [Required(ErrorMessage = "Campo Estado é Obrigatório"), MaxLength(2)]
        public string? Estado { get; set; }

        [Required(ErrorMessage = "Campo Cidade é Obrigatório")]
        public int? Cidade { get; set; }

        [Required(ErrorMessage = "Campo Rua é Obrigatório")]
        public string? Rua { get; set; }

        [Required(ErrorMessage = "Campo Bairro é Obrigatório")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "Campo Número é Obrigatório")]
        public int? Numero { get; set; }
    }
}
