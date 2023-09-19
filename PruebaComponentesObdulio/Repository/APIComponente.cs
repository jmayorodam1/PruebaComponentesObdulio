using System.Text;
using System.Xml.Linq;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Repository;
using Newtonsoft.Json;


namespace PruebaComponentesObdulio.Repository
{
    public class APIComponente : IComponenteRepository
    {

        private readonly HttpClient _httpClient;

        public APIComponente(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MyHttpClient");
        }

        public void Actualizar(Componente componente)
        {
            var url = "http://localhost:5146/api/Componentes";
            var json = JsonConvert.SerializeObject(componente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            Console.WriteLine(content);
            _httpClient.PutAsync(url, content);
        }

        public void Agregar(Componente componente)
        {
            var url = "http://localhost:5146/api/Componentes";
            var json = JsonConvert.SerializeObject(componente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.PostAsync(url, content);
        }

        public void Eliminar(int id)
        {
            var url = $"http://localhost:5146/api/Componentes/{id}";
            _httpClient.DeleteAsync(url);
        }

        public Componente ObtenerPorId(int id)
        {
            var url = $"http://localhost:5146/api/Componentes/{id}";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Componente>(response);
        }

        public IEnumerable<Componente> ObtenerTodos()
        {
            var url = "http://localhost:5146/api/Componentes";
            var callResponse = _httpClient.GetAsync(url).Result;
            var response = callResponse.Content.ReadAsStringAsync().Result;
            var lista = JsonConvert.DeserializeObject<List<Componente>>(response);

            return lista;
        }
    }
}
