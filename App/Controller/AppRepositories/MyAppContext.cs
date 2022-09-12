using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.entities;

namespace Controller.AppRepositories
{
    public class MyAppContext : DbContext //To use other methods and create the database. appContext inherits from the DbContext superclass
    {
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
        public DbSet<Torneo> Torneos {get;set;}
        public DbSet<Juez> Jueces {get;set;}
        //Method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //Connection string
                //data Source parameter is the name of the servidor,initial Catalogo parameter is the name of the DB 
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AppDB;");
            }
        }
    }
}