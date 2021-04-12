using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApplication.Models
{
    public class College
    {
        [Display(Name = "Enrollment Number")]
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string StudentName { get; set; }
        [Display(Name = "Department Name")]
        public string Department { get; set; }
    }

}