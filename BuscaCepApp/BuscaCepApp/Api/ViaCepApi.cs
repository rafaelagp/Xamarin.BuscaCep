using System.Net.Http;
using System.Threading.Tasks;
using BuscaCepApp.Model;
using Newtonsoft.Json;

namespace BuscaCepApp.Api
{
    public static class ViaCepApi
    {
        public static async Task<Endereco> GetAsync(string cep)
        {
            using (var client = new HttpClient())
            {
                var apiUrl = "https://viacep.com.br/ws/" + cep + "/json/";
                var enderecoJson = await client.GetStringAsync(apiUrl);
                var endereco = JsonConvert.DeserializeObject<Endereco>(enderecoJson);
                return endereco;
            }
        } 
    }
}
