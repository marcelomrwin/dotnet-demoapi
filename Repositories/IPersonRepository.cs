using System.Collections.Generic;
using demoapi.Models;

namespace demoapi.Repositories{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person> GetAll();
        int GetCount();
        void Remove();
        string Save(Person person);
    }
}