using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogTrackerWeb.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title{ get; set; }

        public string Subject { get; set; }

        public DateTime DOJ { get; set; }

        public string Url { get; set; }
        public string EmpId { get; set; }

    }
}