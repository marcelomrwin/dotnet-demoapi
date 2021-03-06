using System.Collections.Generic;
using System.Linq;
using demoapi.Models;

namespace demoapi.Repositories{
    public class PersonRepository : IPersonRepository
    {
        private Dictionary<int, Person> _persons 
                        = new Dictionary<int, Person>();
 
        public PersonRepository()
        {
            _persons .Add(1, new Person
            {
                Id = 1,
                FirstName = "FN1",
                LastName = "LN1",
                Email = "email1@email.na"
            });
            _persons .Add(2, new Person
            {
                Id = 2,
                FirstName = "FN2",
                LastName = "LN2",
                Email = "email2@email.na"
            });
        }
 
        public Person GetById(int id)
        {
            return _persons[id];
        }
 
        public List<Person> GetAll()
        {
            return _persons.Values.ToList();
        }
 
        public int GetCount()
        {
            return _persons.Count();
        }
 
        public void Remove()
        {
            if (_persons.Keys.Any())
            {
                _persons.Remove(_persons.Keys.Last());
            }
        }
 
        public string Save(Person person)
        {
            if (_persons.ContainsKey(person.Id))
            {
                _persons[person.Id] = person;
                return "Updated Person with id=" + person.Id;
            }
            else
            {
                _persons.Add(person.Id, person);
                return "Added Person with id=" + person.Id;
            }
        }
    }
}