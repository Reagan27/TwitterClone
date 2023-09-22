using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitterClone.Models;
using TwitterClone.Services.USers;

namespace TwitterClone.Services.Users
{
    public class UserService : IUserInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/users";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(content);
            }
            else
            {
                throw new Exception("Failed to retrieve users.");
            }
        }
    }
}
