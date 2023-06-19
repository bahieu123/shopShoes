using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using projectAngular.Configuration;

namespace projectAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(projectAngularWebCoreModule))]
    public class projectAngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public projectAngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(projectAngularWebHostModule).GetAssembly());
        }
    }
}
