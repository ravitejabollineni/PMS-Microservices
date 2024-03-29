﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAPI.Models
{
    public class SignUpModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long ContactNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        
        [Compare("ConfirmPassword")]
        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }
    }
}
