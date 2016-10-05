using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CourseRepository
{
    public interface ICourseRepository
    {
        void InsertCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);
        Course GetCourse(int courseId);
        List<Course> GetAllCourse();
    }
}
