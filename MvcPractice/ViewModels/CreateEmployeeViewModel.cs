﻿using Microsoft.AspNetCore.Http;
using MvcPractice.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPractice.ViewModels
{
    public class CreateEmployeeViewModel
    {       
        [Required]
        [MaxLength(50, ErrorMessage = "Name can not exceed 50 chars")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
