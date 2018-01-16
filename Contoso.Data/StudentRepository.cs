using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context)
        {
        }

        public Student GetStudentByLastName(string lastname)
        {
            var student = _context.people.OfType<Student>().FirstOrDefault(s => s.LastName == lastname);
            return student;
        }
    }
    public interface IStudentRepository : IRepository<Student>//create specifc method for the student
    {
        Student GetStudentByLastName(string lastname);
    }




}
