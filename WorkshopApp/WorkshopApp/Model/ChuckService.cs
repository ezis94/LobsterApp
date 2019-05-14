using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkshopApp.Model.Contract;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using WorkshopApp.Model;

[assembly: Dependency(typeof(ChuckService))]
namespace WorkshopApp.Model
{
    public class ChuckService : IChuckService
    {
        const string endpoint = "https://api.chucknorris.io/jokes/random";
        readonly HttpClient _client;
        public ChuckService()
        {
            _client = new HttpClient();
        }

        public async Task<Joke> GetRandomJokeAsync()
        {
            HttpResponseMessage response = await _client.GetAsync(endpoint);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var joke = JsonConvert.DeserializeObject<Joke>(content);
                return joke;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}
