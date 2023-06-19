using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace projectAngular.EntityFrameworkCore
{
    public static class projectAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<projectAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<projectAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
