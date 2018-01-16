using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public interface IEntity
    {
         int Id { get; set; }
        //look up table not have audit column, so we make id single in one interface
    }
}
