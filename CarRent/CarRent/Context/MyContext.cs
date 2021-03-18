using CarRent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Context
{
    public class MyContext : DbContext
    {
        public MyContext() { }
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        //Configuring DbSet from folder Models
        public DbSet <Role> Roles { get;set; }
    }
}
