using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ExampleOne.Configuration;

namespace ExampleOne.Web.Host.Startup
{
    [DependsOn(
       typeof(ExampleOneWebCoreModule))]
    public class ExampleOneWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ExampleOneWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExampleOneWebHostModule).GetAssembly());
        }
    }
}
