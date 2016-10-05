using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.StudentRepository;

namespace BusinessLogic.StudentService
{
    public class StudentService : IStudentService
    {
        public void InsertStudent(Entities.Student student)
        {
            IStudentRepository repository = new StudentRepository();
            repository.InsertStudent(student);
        }

        public void DeleteStudent(Entities.Student student)
        {
            IStudentRepository repository = new StudentRepository();
            repository.DeleteStudent(student);
        }

        public void UpdateStudent(Entities.Student student)
        {
            IStudentRepository repository = new StudentRepository();
            repository.UpdateStudent(student);
        }


        public Entities.Student GetStudent(int studentId)
        {
            IStudentRepository repository = new StudentRepository();
            return repository.GetStudent(studentId);
        }

        public List<Entities.Student> GetAllStudent()
        {
            IStudentRepository repository = new StudentRepository();
            return repository.GetAllStudent();
        }
    }
}
