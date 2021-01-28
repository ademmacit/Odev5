using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Abstract
{
    interface IStudentManager
    {
        void AddStudent(Student student);
        void DeleteStudent(int studentId);
        List<Student> ListStudents();
        Student GetStudentById(int id);
    }
}
