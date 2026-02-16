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
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        [Display(Name="Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        //agr foreign key ka name aur property name same h to foreign key attribute ki zarurat nhi hoti
        //or agr same name nhi h to foreign key attribute lagana zaruri h
        [Display(Name="Designation")]
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }
    }
}