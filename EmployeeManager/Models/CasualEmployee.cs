using EmployeeManager.Interfaces;
using System;

namespace EmployeeManager.Models
{
    public class CasualEmployee : Employee, IProject, IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Project";
        }
        public string GetProjectDetails(int employeeId)
        {
            return "Child Details";
        }
    }
}
