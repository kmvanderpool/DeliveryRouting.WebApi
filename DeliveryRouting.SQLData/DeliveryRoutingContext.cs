using DeliveryRouting.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeliveryRouting.SQLData
{
    public class DeliveryRoutingContext : DbContext
    {
        public DeliveryRoutingContext(DbContextOptions<DeliveryRoutingContext> options)
            : base(options)
        { }

        public DbSet<Family> Families { get; set; }
        public DbSet<Route> Routes { get; set; }
    }
}
