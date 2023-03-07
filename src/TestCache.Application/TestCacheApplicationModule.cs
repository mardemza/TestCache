using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestCache.Authorization;

namespace TestCache
{
    [DependsOn(
        typeof(TestCacheCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestCacheApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestCacheAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestCacheApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
