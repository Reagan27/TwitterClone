using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TwitterClone.Models;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<User>> GetUsersAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
    }

    public async Task<List<Post>> GetPostsAsync(int userId)
    {
        return await _httpClient.GetFromJsonAsync<List<Post>>($"https://jsonplaceholder.typicode.com/posts?userId={userId}");
    }

    public async Task<List<Comment>> GetCommentsAsync(int postId)
    {
        return await _httpClient.GetFromJsonAsync<List<Comment>>($"https://jsonplaceholder.typicode.com/comments?postId={postId}");
    }
}
