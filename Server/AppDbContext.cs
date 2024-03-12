// AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using BlazorProject.Shared.DataAnnotations;
using System.Collections.Generic;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
            { }
    public DbSet<User> User { get; set; }
}