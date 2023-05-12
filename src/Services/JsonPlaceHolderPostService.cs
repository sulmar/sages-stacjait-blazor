using StacjaIT.BlazorApp.Abstractions;
using StacjaIT.BlazorApp.Models;
using System.Net.Http.Json;

namespace StacjaIT.BlazorApp.Services;

public class JsonPlaceHolderPostService : IPostService
{
    private readonly HttpClient http;
    public JsonPlaceHolderPostService(HttpClient http) => this.http = http;

    public Task<List<Post>> GetByUser(int userId) => http.GetFromJsonAsync<List<Post>>($"/posts?userId={userId}");
}
