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
    public class CourseRepository : Repository<Course>, ICourseRepository
    {

        public CourseRepository(PlutoContext context)
            :base(context)
        {

        }

        public IEnumerable<Course> GetCoursesWithAuthors()
        {
            return Context.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .ToList();
        }
        

        public IEnumerable<Course> GetTopSellingCourses()
        {
            return Context.Courses
                .OrderByDescending(c => c.Name)
                .Take(2)
                .ToList();
        }

        public PlutoContext Context 
        {
            get { return _context as PlutoContext; }
        }

    }
}
