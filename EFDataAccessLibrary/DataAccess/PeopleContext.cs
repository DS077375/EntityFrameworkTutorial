using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.DataAccess
{
    public class PeopleContext : DbContext
    {
        // Gives you a constructor if you want that calls the base constructor
        public PeopleContext(DbContextOptions options): base(options) { }

        // Create Tables (sets of Data)
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
    }
}
