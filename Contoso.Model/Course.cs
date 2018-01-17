using Contoso.Data;
using Contoso.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    public class Course : AuditableEntity
    {
        [StringLength(50, MinimumLength = 3)]//if not specify every things will be varchar(max)
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }//use lazy loading to fetch the departmentName from the department table to the course table
        public ICollection<Enrollment> Enrollment { get; set; }

        public ICollection<Instructor> Instructor{ get; set; }//one course can have multi instructor
    }

}
