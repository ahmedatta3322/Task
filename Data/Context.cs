using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace task.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
