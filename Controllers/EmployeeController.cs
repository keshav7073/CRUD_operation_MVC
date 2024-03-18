using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int id)
        {
            MVC_DBEntities1 dbcontxt = new MVC_DBEntities1();
            List<Employee> empList = dbcontxt.Employees.Where(emp =>emp.DepartmentId==id).ToList();
            return View(empList);
        }
        public ActionResult Details(int id)
        {
            MVC_DBEntities1 dbcontxt = new MVC_DBEntities1();
            Employee emp = dbcontxt.Employees.FirstOrDefault(x=>x.EmployeeId==id);
            return View(emp);
        }
    }
}