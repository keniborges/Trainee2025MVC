namespace SenaiMvc.Service.Interfaces
{
	public interface IApiService
	{
		Task<T> GetAsync<T>(string endpoint);

		Task<T> PostAsync<T>(string endpoint, object data);

		Task<bool> DeleteAsync(string endpoint);

    }
}
