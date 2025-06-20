using System.ComponentModel.DataAnnotations;

namespace SenaiMvc.Models.Escola
{
	public class EnderecoModel
	{
		public string Estado { get; set; }

		public string Cidade { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }
    }
}
