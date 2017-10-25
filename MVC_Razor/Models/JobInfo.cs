using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Razor.Models
{
    public class JobInfo
    {
        [Required(ErrorMessage = "Too short")]
        public string Description { get; set; }
    }
}