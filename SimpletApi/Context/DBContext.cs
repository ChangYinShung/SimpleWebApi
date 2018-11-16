using Microsoft.EntityFrameworkCore;
using SimpletApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpletApi.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Domains.Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sample.db");
        }
    }
}
