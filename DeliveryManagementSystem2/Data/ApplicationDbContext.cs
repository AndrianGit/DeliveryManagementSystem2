using Microsoft.EntityFrameworkCore;
using DeliveryManagementSystem2.Models;
using System.Collections.Generic;

namespace DeliveryManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
