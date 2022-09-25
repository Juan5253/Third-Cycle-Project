using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IREquipo
    {
        public bool createEquipo(Equipo equipo);
        public Equipo searchEquipo(int id);
        public bool deleteEquipo(int id);
        public bool updateEquipo(Equipo equipo);
        public IEnumerable<Equipo> listEquipos();
        public List<Equipo> listquipos1();
    }
}