using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.entities;

namespace Controller.AppRepositories
{
    public class AppContext : DbContext 
    {
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Colegio> Colegios {get;set;}
        public DbSet<Patrocinador> Patrocinadores {get;set;}
    }
}