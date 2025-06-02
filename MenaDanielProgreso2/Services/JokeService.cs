using MenaDanielProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MenaDanielProgreso2.Services
{
    class JokeService
    {
        private readonly HttpClient _httpClient;
        public JokeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<JokeModel> GetRandomJokeAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://official-joke-api.appspot.com/random_joke");
                response.EnsureSuccessStatusCode();
                JokeModel joke = await response.Content.ReadFromJsonAsync<JokeModel>();
                return joke;
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
    }
}
