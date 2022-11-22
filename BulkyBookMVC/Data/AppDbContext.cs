using BulkyBookMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookMVC.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}

