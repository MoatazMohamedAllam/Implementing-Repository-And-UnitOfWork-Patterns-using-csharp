using Repositoy_UnitOfWork_Patterns.Core.Domain;
using Repositoy_UnitOfWork_Patterns.Persistence.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy_UnitOfWork_Patterns.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            :base("name=DefaultConnection")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());

        }
    }
}
