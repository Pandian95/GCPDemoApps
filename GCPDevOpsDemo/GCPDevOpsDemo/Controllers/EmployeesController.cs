using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCPDevOpsDemo.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace GCPDevOpsDemo.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// GET api/Employees
        [EnableCors("AllowMyOrigin")]
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return getAllEmployees();
        }

        private IEnumerable<Employee> getAllEmployees()
        {
            var employeeList = new List<Employee>();

            var emp1 = new Employee() { EmployeeID = 10001, EmployeeName = "Sandy", Company = "Cognizant", Designation = "SA", Role = "Team Lead", Country = "US" };
            var emp2 = new Employee() { EmployeeID = 10002, EmployeeName = "Raja", Company = "Infosys", Designation = "PA", Role = "Trainee", Country = "Canada" };
            var emp3 = new Employee() { EmployeeID = 10003, EmployeeName = "Johnes", Company = "IBM", Designation = "Consultant", Role = "Sr.Developer", Country = "UK" };
            var emp4 = new Employee() { EmployeeID = 10004, EmployeeName = "Joseph", Company = "TCS", Designation = "A", Role = "Developer", Country = "INDIA" };
            var emp5 = new Employee() { EmployeeID = 10005, EmployeeName = "Simon", Company = "Accenture", Designation = "SE", Role = "Tester",Country = "AUS" };
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);
            return employeeList.AsEnumerable();
        }
    }
}