﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCtestCore.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCtestCore.Data
{
    public class HelloWorldContext : DbContext
    {

        public DbSet<HelloWorld> HelloWorlds { get; set;}
    }
}