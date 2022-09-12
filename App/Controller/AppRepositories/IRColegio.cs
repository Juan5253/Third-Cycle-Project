using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRColegio
    {
        public bool createColegio(Colegio colegio);
        public Colegio searchColegio(int id);
        public bool deleteColegio(int id);
        public bool updateColegio(Colegio colegio);
        public IEnumerable<Colegio> listColegios();
        public List<Colegio> listColegios1();   
    }
}