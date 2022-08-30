using restWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace restWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
