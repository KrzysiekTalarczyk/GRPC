using System.Collections.Generic;
using User.Domain;

namespace User.Application
{
    public interface IPersonService
    {
        IList<Person> GetPersons();
    }
}
