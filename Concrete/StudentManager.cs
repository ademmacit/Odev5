using Odev5.Abstract;
using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class StudentManager : IStudentManager
    {
        IStudentValidator _studentValidator;
        List<Student> students;

        public StudentManager(IStudentValidator studentValidator)
        {
            _studentValidator = studentValidator;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (_studentValidator.Validate(student))
            {
                students.Add(student);
                Console.WriteLine("Student added");
            }
            else
            {
                Console.WriteLine("validation failed");
            }
        }

        public void DeleteStudent(int studentId)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == studentId)
                {
                    students.RemoveAt(i);
                    break;
                }
            }

        }

        public Student GetStudentById(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return students[0];
        }

        public List<Student> ListStudents()
        {
            return students;
        }
    }
}
