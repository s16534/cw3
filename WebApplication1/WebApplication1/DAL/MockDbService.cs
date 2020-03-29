using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MockDbService : IdbService
    {
        private static List<Student> students = new List<Student>();

        public MockDbService()
        {
            students.Add(new Student
            {
                IntStudent = 1,
                FirstName = "Jarosław",
                LastName = "Rodak"
            });
            students.Add(new Student
            {
                IntStudent = 2,
                FirstName = "Maciej",
                LastName = "Polak"
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
