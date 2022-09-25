using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRTorneo
    {
        public bool createTorneo(Torneo torneo);
        public Torneo searchTorneo(int id);
        public bool deleteTorneo(int id);
        public bool updateTorneo(Torneo torneo);
        public IEnumerable<Torneo> listTorneos();
        public List<Torneo> listTorneos1();
    }
}