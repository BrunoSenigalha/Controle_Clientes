using Microsoft.EntityFrameworkCore;
using ClientsControl.Domain.Entities.Client;
using ClientsControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsControl.Infraestructure.Context
{
    public class EntitiesContext(DbContextOptions<EntitiesContext> options, DbSet<Store> stores, DbSet<Address> addresses, DbSet<User> users) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
