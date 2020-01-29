using System.Collections.Generic;
using User.Domain;
using User.Persistence;

namespace User.Application
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository userRepository)
        {
            _personRepository = userRepository;
        }
        public IList<Person> GetPersons()
        {
            return _personRepository.GetPersons();
        }
    }
}
