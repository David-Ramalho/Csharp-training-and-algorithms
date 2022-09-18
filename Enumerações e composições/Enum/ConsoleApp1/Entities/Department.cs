using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {
            //Basic constructor
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
