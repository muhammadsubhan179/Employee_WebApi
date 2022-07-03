using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWebAPI.Models
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployeeRecord(int id);
        string InsertEmployeeRecord(EmployeeModel model);
        string DeleteEmployeeRecord(int id);
        string UpdateEmployeeRecord(EmployeeModel model);
    }
}
