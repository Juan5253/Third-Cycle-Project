using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRJuez
    {
        public bool createJuez(Juez juez);
        public Juez searchJuez(int id);
        public bool deleteJuez(int id);
        public bool updateJuez(Juez juez);
        public IEnumerable<Juez> listJueces();
        public List<Juez> listJueces1();
    }
}