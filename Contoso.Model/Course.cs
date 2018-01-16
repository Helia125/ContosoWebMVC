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
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }

    }

}
