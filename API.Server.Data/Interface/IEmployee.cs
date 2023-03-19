using API.Shared.Model;
using System.Collections.Generic;

namespace API.Server.Data.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployee(int id);
    }
}
