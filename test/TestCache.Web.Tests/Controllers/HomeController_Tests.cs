using System.Threading.Tasks;
using TestCache.Models.TokenAuth;
using TestCache.Web.Controllers;
using Shouldly;
using Xunit;

namespace TestCache.Web.Tests.Controllers
{
    public class HomeController_Tests: TestCacheWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}