using Microsoft.EntityFrameworkCore;
using Walkiria.Restrictions.DataContext.Models;

namespace Walkiria.Restrictions.DataContext;

public class RestrictionDataContext : DbContext
{
    public RestrictionDataContext(DbContextOptions<RestrictionDataContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        Database.EnsureCreated();
    }

    public DbSet<Restriction> Restrictions { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Restriction>().HasKey(x => new { x.UserTgId, x.GroupTgId });
    }
}