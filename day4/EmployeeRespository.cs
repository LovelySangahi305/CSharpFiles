using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class EmployeeRepository
    {
        public Employee[] employees;

        public EmployeeRepository(Employee[] employees)
        {
            this.employees = employees;
        }

        public void DisplayDetails()
        {
            foreach (Employee e in employees)
            {

                Console.WriteLine($"{e.Empid} {e.EmpName} {e.Designation} {e.Department}");
            }

        }

        public void DisplayDetails2(string dept)
        {
            foreach (Employee e in employees)
            {
                if (e.Department.Equals(dept))
                    Console.WriteLine($"{e.Empid} {e.EmpName} {e.Designation} {e.Department}");
            }
        }

    }
}
