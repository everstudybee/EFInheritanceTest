using EFInheritanceTest.MVC.Models;

using Microsoft.EntityFrameworkCore;

namespace EFInheritanceTest.MVC.Data;

public class EFInheritanceTestDbContext : DbContext
{
    public EFInheritanceTestDbContext(DbContextOptions<EFInheritanceTestDbContext> options) : base(options) { }

    public DbSet<Workshop> Workshops { get; set; }
}
