using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetStudentByTitle(string title)
        {
            return _courseRepository.GetStudentByTitle(title);
        }
    }

    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();
        Course GetStudentByTitle(string title);
    }
}
