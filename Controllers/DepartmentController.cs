using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Detail
        public ActionResult Index()
        {
            MVC_DBEntities1 dbcontext = new MVC_DBEntities1();
            
            List<Department> DepartmentList = dbcontext.Departments.ToList();

            return View(DepartmentList);
        }
    }
}