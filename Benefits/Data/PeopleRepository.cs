using Benefits.Models;
using System;
using System.Collections.Generic;

namespace Benefits.Data
{
    public interface IPeopleRepository
    {
        List<Person> Get();
    }

    public class PeopleRepository : IPeopleRepository
    {
        public List<Person> Get()
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

            return people;
        }
    }
}
