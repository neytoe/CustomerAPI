using Microsoft.EntityFrameworkCore;
using NadTech.Core.Models;
using System;

namespace NadTech.Infrastructure
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base (options)
        {

        }

        DbSet<Customer> customers { get; set; }
        DbSet<Address> addresses { get; set; }
        DbSet<Order> orders { get; set; }
    }
}
