using Contoso.Data;
using Contoso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)//do not have default constructor
                                                                   //cus this constructor has overwrite the defalut one.
                                                                   //this is find of default one.
        {
            _studentRepository = studentRepository;
        }
        //to create instance of studentservice, we need to pass the object which implements interface IStudentRepository - studentrepository.


        public IEnumerable<Student> GetStudents()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentByLastName(string lastname)
        {
            return _studentRepository.GetStudentByLastName(lastname);
        }
    }

    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByLastName(string lastname);//unusally parameter is lower case.

    }
}
