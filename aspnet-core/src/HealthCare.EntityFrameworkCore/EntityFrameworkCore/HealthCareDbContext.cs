using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HealthCare.Authorization.Roles;
using HealthCare.Authorization.Users;
using HealthCare.MultiTenancy;
using HealthCare.Messages;

namespace HealthCare.EntityFrameworkCore {
    public class HealthCareDbContext : AbpZeroDbContext<Tenant, Role, User, HealthCareDbContext> {
        /* Define a DbSet for each entity of the application */

        //public virtual DbSet<UserProfile> UserProfile { get; set; }

        public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options)
            : base(options) {
        }
    }
}
