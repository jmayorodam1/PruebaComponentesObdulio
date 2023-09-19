using System.Text;
using System.Xml.Linq;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;
using Newtonsoft.Json;

namespace PruebaComponentesObdulio.Repository
{
    public class APIOrdenador : IOrdenadorRepository
    {
        private readonly HttpClient _httpClient;

        public APIOrdenador(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MyHttpClient");
        }

        public void Actualizar(Ordenador ordenador)
        {
            var url = "http://localhost:5146/api/Ordenador";
            var json = JsonConvert.SerializeObject(ordenador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(content);
            _httpClient.PutAsync(url, content);
        }

        public void Agregar(Ordenador ordenador)
        {
            var url = "http://localhost:5146/api/Ordenador";
            var json = JsonConvert.SerializeObject(ordenador);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.PostAsync(url, content);
        }

        public void Eliminar(int id)
        {
            var url = $"http://localhost:5146/api/Ordenador/{id}";
            _httpClient.DeleteAsync(url);
        }

        public Ordenador ObtenerPorId(int id)
        {
            var url = $"http://localhost:5146/api/Ordenador/{id}";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Ordenador>(response);
        }

        public IEnumerable<Ordenador> ObtenerTodos()
        {
            var url = "http://localhost:5146/api/Ordenador";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;
            var lista = JsonConvert.DeserializeObject<List<Ordenador>>(response);

            return lista;
        }
    }
}
