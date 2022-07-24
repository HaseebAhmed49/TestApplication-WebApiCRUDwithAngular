using System;
using FullStack.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

