using Repositoy_UnitOfWork_Patterns.Core.Domain;
using Repositoy_UnitOfWork_Patterns.Core.Repositories;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy_UnitOfWork_Patterns.Persistence.Repositories
{
    class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context)
            :base(context)
        {

        }
        public Author GetAuthorCourses(int id)
        {
            return Context.Authors.Include(a => a.Courses).FirstOrDefault(a => a.Id == id);
        }

        public PlutoContext Context 
        {
            get { return _context as PlutoContext; }
        }
    }
}
