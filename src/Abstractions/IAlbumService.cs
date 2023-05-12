
using StacjaIT.BlazorApp.Models;

namespace StacjaIT.BlazorApp.Abstractions;

public interface IAlbumService
{
    Task<List<Album>> GetAll();
}