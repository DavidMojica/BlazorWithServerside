using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Modelos.Entidades;

namespace Cliente.Services
{
    public class PaisService
    {
        private readonly HttpClient _httpClient;
        public PaisService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pais>> ObtenerPaises()
        {

            return await _httpClient.GetFromJsonAsync<List<Pais>>("https://localhost:7069/api/Paises");

            
        }
    }
}
