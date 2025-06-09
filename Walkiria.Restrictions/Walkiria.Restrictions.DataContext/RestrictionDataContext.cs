using Microsoft.EntityFrameworkCore;
using Walkiria.Restrictions.DataContext.Models;

namespace Walkiria.Restrictions.DataContext;

public class RestrictionDataContext(DbContextOptions<RestrictionDataContext> _dbContext) : DbContext
{
    public DbSet<Restriction> Restrictions { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Restriction>().HasNoKey();
        mb.Entity<Restriction>().HasIndex(x => x.TelegramId);
    }
}