namespace Emp_dep_desg_layout.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Emp_dep_desg_layout.Data.Applicationdbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Emp_dep_desg_layout.Data.Applicationdbcontext context)
        {
            //  This method will be called after migrating to the latest version.

            // Seed Departments
            context.Departments.AddOrUpdate(d => d.name,
                new Models.department { id = 1, name = "Human Resources" },
                new Models.department { id = 2, name = "Finance" },
                new Models.department { id = 3, name = "IT" }
            );

            // Seed Designations
            context.Designations.AddOrUpdate(ds => ds.Name,
                new Models.Designation { Id = 1, Name = "Manager" },
                new Models.Designation { Id = 2, Name = "Developer" },
                new Models.Designation { Id = 3, Name = "Accountant" }
            );

            context.SaveChanges();

            // Seed Employees
            context.Employees.AddOrUpdate(e => e.Name,
                new Models.Employee { Id = 1, Name = "Alice", Salary = 60000, DepartmentId = 3, DesignationId = 2 },
                new Models.Employee { Id = 2, Name = "Bob", Salary = 80000, DepartmentId = 1, DesignationId = 1 },
                new Models.Employee { Id = 3, Name = "Carol", Salary = 50000, DepartmentId = 2, DesignationId = 3 }
            );

            context.SaveChanges();
        }
    }
}
