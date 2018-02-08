using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.EntityFrameworkCore
{
    public static class HealthCareDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HealthCareDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HealthCareDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
