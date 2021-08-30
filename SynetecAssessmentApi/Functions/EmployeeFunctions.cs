using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Functions
{
    public class EmployeeFunctions
    {
        public EmployeeDto MapToEmployeeDto(Employee employee)
        {
            return new EmployeeDto
            {
                Fullname = employee.Fullname,
                JobTitle = employee.JobTitle,
                Salary = employee.Salary,
                Department = new DepartmentDto
                {
                    Title = employee.Department.Title,
                    Description = employee.Department.Description
                }
            };
        }
    }
}
