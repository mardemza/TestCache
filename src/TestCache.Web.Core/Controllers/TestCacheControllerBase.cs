using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestCache.Controllers
{
    public abstract class TestCacheControllerBase: AbpController
    {
        protected TestCacheControllerBase()
        {
            LocalizationSourceName = TestCacheConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
