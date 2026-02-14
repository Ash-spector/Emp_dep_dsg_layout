using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emp_dep_desg_layout.Models
{
    public class Department
    {
        public int id { get; set; }
        [Required(ErrorMessage="Enter Department name")]
        public string name { get; set; }
    }
}