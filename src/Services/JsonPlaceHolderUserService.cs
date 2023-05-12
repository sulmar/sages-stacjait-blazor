using StacjaIT.BlazorApp.Abstractions;
using StacjaIT.BlazorApp.Models;
using System.Net.Http.Json;

namespace StacjaIT.BlazorApp.Services;

public class JsonPlaceHolderUserService : IUserService
{
    private readonly HttpClient http;
    public JsonPlaceHolderUserService(HttpClient http) => this.http = http;
    public Task<List<User>> GetAllAsync() => http.GetFromJsonAsync<List<User>>("/users");
}
