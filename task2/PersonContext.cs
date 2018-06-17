using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class PersonContext : DbContext
    {
        public PersonContext() :base("DbConnection")
        { }
          
        public DbSet<Person> People { get; set; }
    }
}
