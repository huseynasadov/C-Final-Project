using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GymRegistration.Models;

namespace GymRegistration.DAL
{
    class GymDbContext : DbContext
    {
        public GymDbContext():base("GymConnection") {}

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuOrder> MenuOrders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
