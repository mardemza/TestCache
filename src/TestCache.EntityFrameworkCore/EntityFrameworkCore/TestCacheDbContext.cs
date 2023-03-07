using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestCache.Authorization.Roles;
using TestCache.Authorization.Users;
using TestCache.MultiTenancy;
using TestCache.Domain;

namespace TestCache.EntityFrameworkCore
{
    public class TestCacheDbContext : AbpZeroDbContext<Tenant, Role, User, TestCacheDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Player> Players { get; set; }

        public TestCacheDbContext(DbContextOptions<TestCacheDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PlayerConfig());
        }
    }
}
