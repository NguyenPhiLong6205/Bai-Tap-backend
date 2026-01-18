using Microsoft.EntityFrameworkCore;
using bt.Core.Entities;

namespace bt.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Technology> Technologies { get; set; }
}