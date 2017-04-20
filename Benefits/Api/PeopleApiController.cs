using Benefits.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Benefits.Api
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        // GET: api/people
        [HttpGet]
        public JsonResult Get()
        {
            var people = new List<Person>()
            {
                new Person() {
                    FirstName = "Max",
                    LastName = "Otto",
                    Birthday = DateTime.Parse("5/11/1980"),
                    Relation = "Employee"
                }
            };

            return Json(people);
        }
    }
}
