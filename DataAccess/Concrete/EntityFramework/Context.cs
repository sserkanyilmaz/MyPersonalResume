using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Person> person { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Message> messages { get; set; }
        
    }
}
