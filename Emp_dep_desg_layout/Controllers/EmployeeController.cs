using Emp_dep_desg_layout.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Emp_dep_desg_layout.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Applicationdbcontext context;
        public EmployeeController()
        {
            context = new Applicationdbcontext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employeelist = context.Employees.Include(e => e.Department).Include(e => e.Designation).ToList();
            return View(employeelist);
        }
    }
}