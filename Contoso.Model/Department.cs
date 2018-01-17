using Contoso.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Department:AuditableEntity
    {
        public String Name { get; set; }
        public Decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public ICollection<Course> Course { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Insturctor { get; set; }//navigation property
        //virtual can create navigation property of lazy loading
        //use lazy loading to fetch the instructorFirstname from the instructor table to the department table

    }
}
