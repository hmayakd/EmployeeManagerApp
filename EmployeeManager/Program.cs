using System;
using EmployeeManager.Models;
using EmployeeManager.Interfaces;

namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            employees[0] = new ContractualEmployee();
            employees[1] = new CasualEmployee();

            foreach (IEmployee e in employees)
            {
                e.GetEmployeeDetails(1245);
            }
        }
    }
}
