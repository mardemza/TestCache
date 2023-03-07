using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TestCache.EntityFrameworkCore
{
    public static class TestCacheDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TestCacheDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TestCacheDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
