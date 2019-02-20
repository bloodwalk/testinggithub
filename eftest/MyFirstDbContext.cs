using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eftest.Models;
using Microsoft.EntityFrameworkCore;


namespace eftest
{
    public class MyFirstDbContext : DbContext
    {
        public MyFirstDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
