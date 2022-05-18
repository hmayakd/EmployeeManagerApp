using System;
using EmployeeManager.Interfaces;

namespace EmployeeManager.Models
{
    public class ContractualEmployee : Employee, IEmployee
    {
        // May be for contractual employee we do not need to store the details into database.
        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Project";
        }
    }
}
