using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlHotChocolateNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlHotChocolateNetCore.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext()
        {

        }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Dusan; Database=graphqlTest; Trusted_Connection=True;");

        }

        public DbSet<User> User { get; set; }

    }
}