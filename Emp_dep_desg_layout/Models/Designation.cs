using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Emp_dep_desg_layout.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}