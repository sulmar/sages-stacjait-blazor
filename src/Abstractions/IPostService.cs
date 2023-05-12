
using StacjaIT.BlazorApp.Models;

namespace StacjaIT.BlazorApp.Abstractions;

public interface IPostService
{
    Task<List<Post>> GetByUser(int userId);
}