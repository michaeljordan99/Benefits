using Benefits.Api;
using Benefits.Models;
using Benefits.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Benefits1.Tests
{
    public class PeopleControllerTests
    {
        [Fact]
        public void PeopleTest()
        {
            var mockPeopleRepository = new MockPeopleRepository();

            var controller = new PeopleController(mockPeopleRepository);

            var result = controller.Get() as OkObjectResult;

            var response = (List<Person>)result.Value;

            Assert.Equal(result.StatusCode, 200);

            Assert.Equal(response[0].FirstName, "Unit");
        }
    }
}
