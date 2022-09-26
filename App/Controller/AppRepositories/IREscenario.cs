using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IREscenario
    {
        public bool createEsceneario(Escenario escenario);
        public Escenario searchEscenario(int id);
        public bool deleteEscenario(int id);
        public bool updateEsceneario (Escenario escenario);
        public IEnumerable<Escenario> listEscenarios();
        public List<Escenario> listEscenarios1();
    }
}