using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AkaraDbContext : DbContext
    {
        public AkaraDbContext(DbContextOptions<AkaraDbContext> options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<Property> Properties { get; set; }
        DbSet<Contract> Contracts { get; set; }

    }
}

