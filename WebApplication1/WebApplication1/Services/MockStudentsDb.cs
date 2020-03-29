using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MockStudentsDb : IStudentsDb
    {
        private static List<Student> students = new List<Student>();

        public MockStudentsDb()
        {
            students.Add(new Student
            {
                IntStudent = 1,
                FirstName = "Jarosław",
                LastName = "Rodak",
                IndexNumber = "11111"
            });
            students.Add(new Student
            {
                IntStudent = 2,
                FirstName = "Maciej",
                LastName = "Polak",
                IndexNumber = "11112"
            });
        }

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

    }
}
