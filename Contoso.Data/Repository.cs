using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly IDbSet<T> dbSet;
        protected ContosoDbContext _context;//class can be inheritant

        public Repository(ContosoDbContext context)//ctor tab tab
        {
            _context = context;
            dbSet = context.Set<T>();//dbset is generic, cus we have diff models
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();//don't want exception happen, LINQ
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList();//AdNoTracking is a mothod improve the performance w7d1 - 1 - 1:12:02
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);//Find() is inside the EF.
        }

        public IQueryable<T> GetQueryable()//reuse the class, use this we do not need to typing everytime.
        {
            return dbSet.AsQueryable<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);//EF syntax, 
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
