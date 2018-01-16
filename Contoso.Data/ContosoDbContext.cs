using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext //name need same as the connectionsting, if not we can use the
    {
        //public ContosoDbContext() : base("name = ContosoDbContext")
        //{

        //}

        public DbSet<People> people { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<Instructor> instructors { get; set; }

    }
}
