using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestCache.Configuration;

namespace TestCache.Web.Host.Startup
{
    [DependsOn(
       typeof(TestCacheWebCoreModule))]
    public class TestCacheWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TestCacheWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestCacheWebHostModule).GetAssembly());
        }
    }
}
