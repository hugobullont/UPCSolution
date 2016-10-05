using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        public void InsertCourse(Entities.Course course)
        {
            EFUPCConnectionString UPCModel = new EFUPCConnectionString();
            UPCModel.Courses.Add(course);
            UPCModel.SaveChanges();
            

        }

        public void UpdateCourse(Entities.Course course)
        {
            EFUPCConnectionString UPCModel = new EFUPCConnectionString();
            Course c = UPCModel.Courses.Find(course.Id);
            if (c != null)
            {
                UPCModel.Entry(c).CurrentValues.SetValues(course);
                UPCModel.SaveChanges();
            }
        
        }

        public void DeleteCourse(Entities.Course course)
        {
            EFUPCConnectionString UPCModel = new EFUPCConnectionString();
            Course c = UPCModel.Courses.Find(course.Id);

            if( c != null)
            {
                UPCModel.Courses.Remove(c);
                UPCModel.SaveChanges();
            }
        }

        public Entities.Course GetCourse(int courseId)
        {
            using (var model = new EFUPCConnectionString())
            {
                var course = from c in model.Courses
                             where c.Id == courseId
                             select c;
                return course.FirstOrDefault();
            }
        }

        public List<Entities.Course> GetAllCourse()
        {
            EFUPCConnectionString UPCModel = new EFUPCConnectionString();
            List<Course> courses = (from c in UPCModel.Courses select c).ToList();
            return courses;
        }
    }
}
