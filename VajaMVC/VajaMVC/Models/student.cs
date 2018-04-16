﻿using System;
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
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        public int Age { get; set; }
    }
}