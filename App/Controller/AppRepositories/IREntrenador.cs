using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IREntrenador
    {
        public bool createEntrenador(Entrenador Entrenador);
        public Entrenador searchEntrenador(int id);
        public bool deleteEntrenador(int id);
        public bool updateEntrenador(Entrenador entrenador);
        public IEnumerable<Entrenador> listEntrenadores();
        public List<Entrenador> listEntrenadores1();
    }
}