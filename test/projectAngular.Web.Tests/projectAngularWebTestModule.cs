using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using projectAngular.EntityFrameworkCore;
using projectAngular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace projectAngular.Web.Tests
{
    [DependsOn(
        typeof(projectAngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class projectAngularWebTestModule : AbpModule
    {
        public projectAngularWebTestModule(projectAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(projectAngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(projectAngularWebMvcModule).Assembly);
        }
    }
}