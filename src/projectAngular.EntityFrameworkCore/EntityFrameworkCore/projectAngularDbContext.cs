using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using projectAngular.Authorization.Roles;
using projectAngular.Authorization.Users;
using projectAngular.MultiTenancy;
using projectAngular.Category;

namespace projectAngular.EntityFrameworkCore
{
    public class projectAngularDbContext : AbpZeroDbContext<Tenant, Role, User, projectAngularDbContext>
    {
        public projectAngularDbContext(DbContextOptions<projectAngularDbContext> options)
            : base(options)
        {
        }
       public DbSet<CategoryPro> categoryPros { get; set; }
       
    }
}
