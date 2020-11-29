using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace HomeAssignment.Models
{

    public class AppDBContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
