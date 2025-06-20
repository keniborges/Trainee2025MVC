namespace SenaiMvc.Models.Escola
{
	public class EstadoModel
	{

		public EstadoModel()
		{
			Uf = new List<string>
		{
			"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
			"MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
			"RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
		};
		}
		public List<string> Uf {  get; set; }
	}
}
