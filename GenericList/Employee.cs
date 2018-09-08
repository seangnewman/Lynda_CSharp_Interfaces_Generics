using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Employee
    {
        public string mName { get; set; }
        public int mSalary { get; set; }

        public Employee(string name, int salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }
    }
}
