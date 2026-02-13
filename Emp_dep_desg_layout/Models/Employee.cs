using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Emp_dep_desg_layout.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public department Department { get; set; }
        //agr foreign key ka name aur property name same h to foreign key attribute ki zarurat nhi hoti
        //or agr same name nhi h to foreign key attribute lagana zaruri h
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
    }
}