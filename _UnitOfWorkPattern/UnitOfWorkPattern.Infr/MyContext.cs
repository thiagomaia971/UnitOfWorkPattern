using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repositories;

namespace UnitOfWorkPattern.Infr
{
    public class MyContext : DbContext
    {
        // Yours DbSet
        // public DbSet<Cliente> Clientes { get; set; }

        public MyContext(): base("name=DefaultConnetion")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Yours TypeConfiguration
            //modelBuilder.Configurations.Add(new ClienteEntityTypeConfiguration());
        }

    }
}
