using Benefits.Data;
using System;
using System.Collections.Generic;
using Benefits.Models;

namespace Benefits.Tests.Mocks
{
    public class MockPeopleRepository : IPeopleRepository
    {
        public List<Person> Get()
        {
            var people = new List<Person>()
            {
                new Person() {
                    FirstName = "Unit",
                    LastName = "Test",
                    Birthday = DateTime.Parse("5/11/1980"),
                    Relation = "Employee"
                }
            };

            return people;
        }
    }
}
