using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Vivero.Model
{
    public class BaseDeDatos : DbContext
    {
        public BaseDeDatos():base("name=Vivero")
        {

        }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<Persona> personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}