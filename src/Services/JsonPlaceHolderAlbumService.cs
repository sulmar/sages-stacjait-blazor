using StacjaIT.BlazorApp.Abstractions;
using StacjaIT.BlazorApp.Models;
using System.Net.Http.Json;

namespace StacjaIT.BlazorApp.Services;

public class JsonPlaceHolderAlbumService : IAlbumService
{
    private readonly HttpClient http;
    public JsonPlaceHolderAlbumService(HttpClient http) => this.http = http;
    public Task<List<Album>> GetAll() => http.GetFromJsonAsync<List<Album>>($"/albums");

}
