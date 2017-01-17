using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCtestCore.Models
{
    public class HelloWorld : Controller
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public DateTime year { get; set; }
        
        public HelloWorld (int _id,string _name,DateTime _year)
        {
            id = _id;
            name = _name;
            year = _year;
        }
    }
}
