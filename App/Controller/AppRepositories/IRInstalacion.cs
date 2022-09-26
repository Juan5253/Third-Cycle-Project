using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRInstalacion
    {
        public bool createInstalacion(Instalacion instalacion);
        public Instalacion searchInstalacion( int id);
        public bool deleteInstalacion(int id);
        public bool updateInstalacion(Instalacion instalacion);
        public IEnumerable<Instalacion> listInstalaciones();
        public List<Instalacion> listInstalaciones1();
    }
}