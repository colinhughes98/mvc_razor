using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_Razor.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        [DisplayName("Previous roles")]
        public IList<string> PreviousJobs { get; set; }
    }
}