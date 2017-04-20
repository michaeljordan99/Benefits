using Benefits.Data;
using Microsoft.AspNetCore.Mvc;

namespace Benefits.Api
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        // GET: api/people
        [HttpGet]
        public IActionResult Get()
        {
            var people = _peopleRepository.Get();

            return new OkObjectResult(people);
        }
    }
}
