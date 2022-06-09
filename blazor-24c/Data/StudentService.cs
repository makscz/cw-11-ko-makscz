using System.Collections.Generic;
using System.Linq;

namespace blazor_24c.Data
{
    public class StudentService : IStudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Test1",
                    LastName = "Test2",
                    Avatar = "Test3",
                    Birthdate = new System.DateTime(2022, 1, 1),
                    Studies = "Test4"
                },
                new Student
                {
                    ID = 1,
                    FirstName = "Adam",
                    LastName = "Kowalski",
                    Avatar = "Test4",
                    Birthdate = new System.DateTime(1990, 1, 1),
                    Studies = "Test4"
                },
                new Student
                {
                    ID = 1,
                    FirstName = "Pitor",
                    LastName = "Piętka",
                    Avatar = "Test5",
                    Birthdate = new System.DateTime(2012, 1, 1),
                    Studies = "Test4"
                }
            };
        }
        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(e => e.ID == id);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public bool Remove(int id)
        {
            return students.Remove(students.Where(e => e.ID == id).FirstOrDefault());
        }
    }
}
