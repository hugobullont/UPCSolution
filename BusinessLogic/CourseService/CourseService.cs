using DataAccess.CourseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CourseService
{
    public class CourseService : ICourseService
    {
        public void InsertCourse(Entities.Course course)
        {
            ICourseRepository repository = new CourseRepository();
            repository.InsertCourse(course);
        }

        public void UpdateCourse(Entities.Course course)
        {
            ICourseRepository repository = new CourseRepository();
            repository.UpdateCourse(course);
        }

        public void DeleteCourse(Entities.Course course)
        {
            ICourseRepository repository = new CourseRepository();
            repository.DeleteCourse(course);
        }

        public Entities.Course GetCourse(int courseId)
        {
            ICourseRepository repository = new CourseRepository();
            return repository.GetCourse(courseId);
        }

        public List<Entities.Course> GetAllCourse()
        {
            ICourseRepository repository = new CourseRepository();
            return repository.GetAllCourse();
        }
    }
}
