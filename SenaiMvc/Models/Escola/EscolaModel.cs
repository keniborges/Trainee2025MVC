using System.ComponentModel.DataAnnotations;

namespace SenaiMvc.Models.Escola
{
    public class EscolaModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é Obrigatório")]
        public string Nome { get; set; }

        public EnderecoModel? Endereco { get; set; }


    }
}
