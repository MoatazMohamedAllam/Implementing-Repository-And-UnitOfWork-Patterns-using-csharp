using Repositoy_UnitOfWork_Patterns.Core;
using Repositoy_UnitOfWork_Patterns.Core.Repositories;
using Repositoy_UnitOfWork_Patterns.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy_UnitOfWork_Patterns.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;
        public ICourseRepository Courses { get; private set; }

        public IAuthorRepository Authors { get; private set; }

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
