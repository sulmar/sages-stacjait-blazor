﻿namespace StacjaIT.BlazorApp.Models;

public class Post : BaseEntity
{
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
