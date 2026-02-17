using Emp_dep_desg_layout.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Emp_dep_desg_layout.Models;

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
            var employeelist = context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation)
                .ToList();
            return View(employeelist);
        }

        public ActionResult Upsert(int? id)
        {
            ViewBag.deplist = context.Departments.ToList();
            ViewBag.dsglist = context.Designations.ToList();
            Employee employee = new Employee();
            if (id == null)
            {
                return View(employee);
            }
            employee = context.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Employee employee)
        {
            ViewBag.deplist = context.Departments.ToList();
            ViewBag.dsglist = context.Designations.ToList();

            if (employee == null) return HttpNotFound();
            if (!ModelState.IsValid) return View(employee);

            if (employee.Id == 0)
            {
                context.Employees.Add(employee);
            }
            else
            {
                var employeefromDb = context.Employees.Find(employee.Id);
                if (employeefromDb == null) return HttpNotFound();
                employeefromDb.Name = employee.Name;
                employeefromDb.Address = employee.Address;
                employeefromDb.Salary = employee.Salary;
                employeefromDb.DepartmentId = employee.DepartmentId;
                employeefromDb.DesignationId = employee.DesignationId;
            }

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var employeeInDb = context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation)
                .FirstOrDefault(e => e.Id == id);
            if (employeeInDb == null) return HttpNotFound();
            return View(employeeInDb);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var employeeInDb = context.Employees.Find(id);
            if (employeeInDb == null) return HttpNotFound();
            context.Employees.Remove(employeeInDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}






