using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogTrackerWeb.Models
{
    public class Employee
    {
        [Key]
        public string EmailId { get; set; }

        public string Name { get; set; }
        public DateTime DOJ { get; set; }
        public int PassCode { get; set; }
    }
}