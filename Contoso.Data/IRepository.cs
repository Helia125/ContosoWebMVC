using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T> where T : class //T can be only class, and not be any other value type, this is called Generic constraints.
                                                    //means you can only replace <T> with any class.
                                                    //if the IRepository<T> where T : struct, it means <T> can only be value types.
    {
        void Add(T entity);//interface only need difinaiton
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> where); //who was calling this method, 
                                                //they can pass LINQ expression
                                                //will translate to a sql query
        void SaveChanges();

    }
}
