using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesConstructors
{
    partial class Student
    {
        private string _name;
        private string _lastname;

        public Student()
        {
            _name = string.Empty;
            _lastname = string.Empty;
        }
    }
    partial class Student
    {
        public Student(string name, string lastName)
        {
            _name = name;
            _lastname = lastName;
        }

        public string GetFullName()
        {
            string fullName = _name + " " + _lastname;

            return fullName;
        }
    }
}
