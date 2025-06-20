using SenaiMvc.Service.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace SenaiMvc.Service.Servicos
{
	public class ApiService : IApiService
	{

		private readonly HttpClient _httpClient;
		private readonly string baseUrl = "https://localhost:7055/";

		public ApiService()
		{
			_httpClient = new HttpClient() { BaseAddress = new Uri( baseUrl) };
		}

		public async Task<T> GetAsync<T>(string endpoint)
		{
			var response = await _httpClient.GetAsync(endpoint);
			response.EnsureSuccessStatusCode();
			var json = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(json);
		}

		public async Task<T> PostAsync<T>(string endpoint, object data)
		{
			var jsonData = JsonConvert.SerializeObject(data);
			var response = await _httpClient.PostAsync(endpoint,
				new StringContent(jsonData, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<bool> DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();
			if (response.IsSuccessStatusCode)			
				return true;
			return false;
        }


    }
}
