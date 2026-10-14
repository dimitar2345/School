using Microsoft.EntityFrameworkCore;

namespace Test1.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Circle.Circle> Circles => Set<Circle.Circle>();
}
