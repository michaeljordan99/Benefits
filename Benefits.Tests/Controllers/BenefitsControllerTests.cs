using Benefits.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Benefits1.Tests
{
    public class BenefitsControllerTests
    {
        [Fact]
        public void BenefitsViewTest()
        {
            var controller = new PeopleApiController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
