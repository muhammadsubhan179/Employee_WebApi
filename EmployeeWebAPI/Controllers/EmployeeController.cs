using EmployeeWebAPI.BE;
using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace EmployeeWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeBE objBE = new EmployeeBE();

        // GET api/Employee/GetEmployeesList
        [HttpGet]
        [Route("GetAllEmployees")]
        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> list = new List<EmployeeModel>();
            list = objBE.GetAllEmployees();
            return list;
        }

        // GET api/Employee/GetEmployee/5
        [HttpGet]
        [Route("GetEmployee")]
        public EmployeeModel GetEmployee(int id)
        {
            return objBE.GetEmployeeRecord(id);
        }

        [HttpPost]
        [Route("InsertOrUpdateEmployeeRecord")]
        public string InsertOrUpdateEmployeeRecord(EmployeeModel model)
        {
            string result;
            if(model.Id == 0) //if id = 0 that means new employee record is to be inserted
            {
                result = objBE.InsertEmployeeRecord(model);
                return result;
            }
            else
            {// to update the employee record
                result = objBE.UpdateEmployeeRecord(model);
                return result;
            }
            
        }

        [HttpGet]
        [Route("DeleteEmployeeRecord")]
        //to delete the employee record against the employee id
        public string DeleteEmployeeRecord(int id)
        {
            return objBE.DeleteEmployeeRecord(id);
        }
    }
}