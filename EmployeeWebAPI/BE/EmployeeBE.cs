using EmployeeWebAPI.DAL;
using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.BE
{
    //business layer inherited from IEmployee repository
    public class EmployeeBE : IEmployeeRepository 
    {
        private readonly EmployeeDAL objDAL = new EmployeeDAL();
        public List<EmployeeModel> GetAllEmployees()
        {
            return  objDAL.GetAllEmployees(); 
            
        }
        public EmployeeModel GetEmployeeRecord(int id)
        {
            return objDAL.GetEmployeeRecord(id);
        }
        public string InsertEmployeeRecord(EmployeeModel model)
        {
            return objDAL.InsertEmployeeRecord(model);
        }
        public string UpdateEmployeeRecord(EmployeeModel model)
        {
            return objDAL.UpdateEmployeeRecord(model);
        }
        public string DeleteEmployeeRecord(int id)
        {
            return objDAL.DeleteEmployeeRecord(id);
        }

    }
}