using System.ComponentModel.DataAnnotations;

namespace StacjaIT.BlazorApp.Models;

// https://github.com/Blazored/FluentValidation

public class User : BaseEntity
{
    [Required, MinLength(3)]
    public string Name { get; set; }
    [Required, MaxLength(20)]
    public string UserName { get; set; }
    public string Email { get; set; }    
    public string Password { get; set; }
}
