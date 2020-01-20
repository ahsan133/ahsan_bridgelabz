using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.EmployeeManager;
using EmployeeManagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controller
{
    public class EmployeeController : ControllerBase
    {
        IEmployeeManager manager = new EmployeeManagers();

        [HttpPost]
        [Route("api/add")]
        public ActionResult AddEmployees(int userId,string name,string email,string password,string address)
        {
            try
            {
                Employee employee = new Employee();

                employee.UserId = userId;
                employee.Name = name;
                employee.Email = email;
                employee.Password = password;
                employee.Address = address;
                this.manager.Add(employee);
                return Ok(employee);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("api/delete")]
        public ActionResult DeleteEmployees(int userId)
        {
            try
            {
                this.manager.Delete(userId);
                return Ok(userId);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }          
        }

        [HttpPut]
        [Route("api/update")]
        public ActionResult UpdateEmployees(int userId, string name, string email, string password, string address)
        {
            try
            {
                Employee employee = new Employee()
                {
                    UserId = userId,
                    Name = name,
                    Email = email,
                    Password = password,
                    Address = address
                };

                this.manager.Update(employee);
                return Ok(employee);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("api/get")]
        public ActionResult GetEmployees()
        {
            try
            {
                IEnumerable<Employee> list = this.manager.Get();
                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/login")]
        public ActionResult LoginEmployees(string email, string password)
        {
            try
            {
                bool flag = this.manager.Login(email, password);
                return Ok(flag);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}