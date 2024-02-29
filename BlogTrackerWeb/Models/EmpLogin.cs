using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogTrackerWeb.Models
{
    public class EmpLogin
    {
        [Key]

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PassCode is required")]
        [DataType(DataType.Password)]
        public int PassCode { get; set; }
    }
}