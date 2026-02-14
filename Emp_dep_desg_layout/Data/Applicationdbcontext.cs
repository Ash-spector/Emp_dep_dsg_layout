using System.Data.Entity;
using Emp_dep_desg_layout.Models;

namespace Emp_dep_desg_layout.Data
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext() : base("constr")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
