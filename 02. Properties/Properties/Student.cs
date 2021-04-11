using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private string _name;
        private string _lastName;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value;  }
        }

        public Student()
        {
            _name = string.Empty;
            _lastName = string.Empty;
        }

        public Student(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }

        public string GetFullName()
        {
            return _name + " " + _lastName;
        }
    }
}