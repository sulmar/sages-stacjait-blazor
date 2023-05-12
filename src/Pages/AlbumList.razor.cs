using Microsoft.AspNetCore.Components;
using StacjaIT.BlazorApp.Abstractions;
using StacjaIT.BlazorApp.Models;

namespace StacjaIT.BlazorApp.Pages;

public partial class AlbumList
{
    [Inject]
    public IAlbumService Api { get; set; }

    private List<Album>? albums;

    protected override async Task OnInitializedAsync()
    {
        albums = await Api.GetAll();        
    }
}
