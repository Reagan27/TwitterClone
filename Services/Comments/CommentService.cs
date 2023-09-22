using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitterClone.Models;

namespace TwitterClone.Services.Comments
{
    public class CommentService : ICommentInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseUrl = "https://jsonplaceholder.typicode.com/comments";

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Comment>> GetCommentsAsync()
        {
            var response = await _httpClient.GetAsync(BaseUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Comment>>(content);
            }
            else
            {
                throw new Exception("Failed to retrieve comments.");
            }
        }

        public async Task<List<Comment>> GetCommentsByPostAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}?postId={id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Comment>>(content);
            }
            else
            {
                throw new Exception($"Failed to retrieve comments for post with ID {id}.");
            }
        }
    }
}
