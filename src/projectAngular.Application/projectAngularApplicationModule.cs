using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using projectAngular.Authorization;

namespace projectAngular
{
    [DependsOn(
        typeof(projectAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class projectAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<projectAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(projectAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
