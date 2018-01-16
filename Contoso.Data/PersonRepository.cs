using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class PersonRepository : Repository<People>, IPersonRepository
    {
        public PersonRepository(ContosoDbContext context) : base(context)
        {
        }


        public People GetByLastName(string lastname)//only implementing 1 class
        {
            var person = _context.people.Where(p => p.LastName == lastname).FirstOrDefault();
            return person;
        }
    }

    //we use this interface to add specific methods
    public interface IPersonRepository : IRepository<People>   //ipersonresposity implementing 9 = 1 + 8 class
    {
        
        People GetByLastName(String name);
    }
}
