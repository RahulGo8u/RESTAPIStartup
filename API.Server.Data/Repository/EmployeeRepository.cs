using API.Server.Data.Interface;
using API.Server.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace API.Server.Data.Repository
{
    public class EmployeeRepository : IEmployee
    {
        List<Employee> lstEmployees = new()
        {
            new() { Id = 1, Name = "Rahul" },
            new() { Id = 2, Name = "Srk" },
            new() { Id = 3, Name = "Hero" }
        };
        public List<Employee> GetAllEmployee()
        {
            return lstEmployees;
        }

        public Employee GetEmployee(int id)
        {
            return lstEmployees.FirstOrDefault(x => x.Id == id);
        }
    }
}
