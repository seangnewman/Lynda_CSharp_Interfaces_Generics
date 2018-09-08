using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{

    class Program
    {
        static void Main(string[] args) {

            // Create a new empty List for Employee Objects
            List<Employee> empList = new List<Employee>(10);

            //Add some records to the list
            empList.Add(new Employee("John Doe", 50000));
            empList.Add(new Employee("Jane Smith", 60000));
            empList.Add(new Employee("Nick Slick", 55000));
            empList.Add(new Employee("Mildred Mintz", 70000));

            // Inspect some list properties
            Console.WriteLine("empList Capacity is : {0}", empList.Capacity);
            Console.WriteLine("empList Count is : {0}", empList.Count);

            //Use Exists() and Find()
            if (empList.Exists(HighPay))
            {
                Console.WriteLine("\nHighly Paid Employee Found!");
            }

            Employee e = empList.Find((x) => {
                return x.mName.StartsWith("J");
            });

            if(e != null)
            {
                Console.WriteLine("Found employee whose name begins with J: {0}", e.mName);
            }


            // Use ForEach to iterate over collection items
            empList.ForEach(TotalSalaries);
            Console.WriteLine("Total Payroll is {0}\n", total);

            //Sort the list using a custom class
            //that implements the IComparer interface
            EmployeeeComparer ec = new EmployeeeComparer();
            empList.Sort(ec);
            foreach (Employee emp in empList)
            {
                Console.WriteLine("Salary for {0} is {1}", emp.mName, emp.mSalary);
            }

             
             
        }

        //Iterator callback for the ForEach method
        static int total = 0;
        static void TotalSalaries(Employee e)
        {
            total += e.mSalary;
        }

        //delegate function to use for the Exists method
        static Boolean HighPay(Employee emp)
        {
            return emp.mSalary >= 65000;
        }


    }
}
