using System;
using System.Collections.Generic;
using User.Domain;

namespace User.Persistence
{
    public class PersonRepository : IPersonRepository
    {

        private List<Person> _personList = new List<Person>()
        {
            new Person()
            {
                Id = 1,
                 Name = "Adam",
                  Address = new Address() { City = " Krakow", Number = 3, Street = "Długa"}
            } ,
            new Person()
            {
                Id = 1,
                 Name = "Jan",
                  Address = new Address() { City = "Warszawa", Number = 3, Street = "Krótka"}
            }
        };
        public List<Person> GetPersons()
        {
            return _personList;
        }
    }

    public interface IPersonRepository
    {
        List<Person> GetPersons();
    }
}
