using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaMVC.Models
{
    public class student
    {
        public int StudentID { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage ="Ime je obvezen podatek")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage = "Starost je obvezna")]
        [Range(18,50, ErrorMessage ="Starost")]
        public int Age { get; set; }
    }
}