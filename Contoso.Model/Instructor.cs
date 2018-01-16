using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model
{
    [Table("Instructor") ]
    public class Instructor : People
    {
        public DateTime? HireDate{ get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
