using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogic.StudentService
{
    public interface IStudentService
    {
        void InsertStudent(Student student);
        void DeleteStudent(Student student);

        void UpdateStudent(Student student);
        Student GetStudent(int studentId);
        List<Student> GetAllStudent();
    }
}
