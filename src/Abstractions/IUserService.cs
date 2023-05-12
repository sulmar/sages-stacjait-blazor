
using StacjaIT.BlazorApp.Models;

namespace StacjaIT.BlazorApp.Abstractions;

public interface IUserService
{
    Task<List<User>> GetAllAsync();
}
