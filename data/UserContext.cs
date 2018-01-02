using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cotizaciones.Models;

namespace Cotizaciones.Data{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options) : base(options)
        {
        }

        //public DbSet<Cotizaciones.User> User { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
            // Utilizacion de SQLite como backend
          //  optionsBuilder.UseSqlite("Data Source=users.db");
        //}

        public DbSet<User> users { get; set; }
    
    
    }
}
