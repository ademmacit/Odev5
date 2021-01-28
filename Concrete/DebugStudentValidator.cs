using Odev5.Abstract;
using Odev5.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5.Concrete
{
    class DebugStudentValidator : IStudentValidator
    {
        public bool Validate(Student student)
        {
            if (student.NationalityNumber == "45465465")
                return true;
            else
                return false;
        }
    }
}
