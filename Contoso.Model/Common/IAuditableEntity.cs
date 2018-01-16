using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public interface IAuditableEntity
    {
        //not necessary every table need to implement this interface, look up table do not need these
        DateTime? CreatedDate  { get; set; }  //nullable type, input can be empty
        DateTime? UpdatedDate { get; set; }
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
    }
}
