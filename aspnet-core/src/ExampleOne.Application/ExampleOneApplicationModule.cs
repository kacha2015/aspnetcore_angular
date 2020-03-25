using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ExampleOne.Authorization;

namespace ExampleOne
{
    [DependsOn(
        typeof(ExampleOneCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ExampleOneApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ExampleOneAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ExampleOneApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
