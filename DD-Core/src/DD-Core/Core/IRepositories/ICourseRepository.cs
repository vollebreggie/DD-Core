using DD.Models;

using System.Collections.Generic;

namespace Queries.Core.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
       
    }
}