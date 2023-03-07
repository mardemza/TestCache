using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestCache.EntityFrameworkCore;
using TestCache.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TestCache.Web.Tests
{
    [DependsOn(
        typeof(TestCacheWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TestCacheWebTestModule : AbpModule
    {
        public TestCacheWebTestModule(TestCacheEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestCacheWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TestCacheWebMvcModule).Assembly);
        }
    }
}