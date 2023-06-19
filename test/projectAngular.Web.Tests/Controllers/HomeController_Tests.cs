using System.Threading.Tasks;
using projectAngular.Models.TokenAuth;
using projectAngular.Web.Controllers;
using Shouldly;
using Xunit;

namespace projectAngular.Web.Tests.Controllers
{
    public class HomeController_Tests: projectAngularWebTestBase
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