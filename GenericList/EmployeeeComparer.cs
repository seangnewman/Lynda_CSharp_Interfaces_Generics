using System.Collections.Generic;

namespace GenericList
{
    internal class EmployeeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.mSalary > y.mSalary)
                return 1;

            if (x.mSalary == y.mSalary)
                return 0;
            else
                return -1;
                
        }
    }
}