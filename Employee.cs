using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    class Employee : Human
    {
        public string Position { get; set; }
        public Employee(string name, string position) : base(name)
        {
            Position = position;
        }
    }
    
}
