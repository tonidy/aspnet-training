﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiRePa.Models
{
    public class PatientCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}