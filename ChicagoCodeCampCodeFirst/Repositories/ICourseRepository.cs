using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ChicagoCodeCampCodeFirst.Models;

namespace ChicagoCodeCampCodeFirst.Repositories
{
    public interface ICourseRepository
    {
        Task<CourseDetail> GetCourse(Guid courseId);
        Task<IEnumerable<CourseSummary>> GetCourses();
    }
}