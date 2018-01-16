using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)//ctor tab tab
        {
            _personRepository = personRepository;
        }

        public void AddPerson(People people)
        {
            _personRepository.Add(people);
            _personRepository.SaveChanges();
        }

        public IEnumerable<People> GetAll()
        {
             return _personRepository.GetAll();
        }

        public People GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }
    }

    public interface IPersonService
    {
        // should include all the method called by the UI
        IEnumerable<People> GetAll();
        People GetPersonById(int id);
        void AddPerson(People people);
    }
}
