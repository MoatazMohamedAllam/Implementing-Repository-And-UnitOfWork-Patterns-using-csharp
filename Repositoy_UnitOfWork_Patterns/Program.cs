using Repositoy_UnitOfWork_Patterns.Core.Domain;
using Repositoy_UnitOfWork_Patterns.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy_UnitOfWork_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var unitOfWork =new UnitOfWork(new PlutoContext()))
            {
                var course = unitOfWork.Courses.Get(2);
                Console.WriteLine(course.Name);
                
                var author = unitOfWork.Authors.Get(3);
                unitOfWork.Authors.Remove(author);
                unitOfWork.Complete();

            }
        }
    }
}
