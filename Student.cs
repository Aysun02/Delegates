using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    class Student : Human
    {
        public double Grade { get; set; }
        public Student(string name, double grade) : base(name)
        {
            Grade = grade;
        }
    }
}


