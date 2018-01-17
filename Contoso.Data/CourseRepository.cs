using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ContosoDbContext context) : base(context)
        {
        }

        public Course GetStudentByTitle(string title)
        {
            var course = _context.course.FirstOrDefault(s => s.Title == title);
            return course;
        }
    }

    public interface ICourseRepository : IRepository<Course>//create specifc method for the course
    {
        Course GetStudentByTitle(string title);
    }
}
