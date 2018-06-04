using System;
using System.Threading.Tasks;
using ChicagoCodeCampCodeFirst.Models;

namespace ChicagoCodeCampCodeFirst.Repositories
{
    public interface ICourseChangeHandler
    {
        Task<CourseDetail> CreateCourse(CourseCreationCommand courseToCreate);
        Task DeleteCourse(Guid courseId);
    }
}