using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRPatrocinador
    {
        public bool createPatrocinador(Patrocinador patrocinador);
        public Patrocinador searchPatrocinador(int id);
        public bool deletePatrocinador(int id);
        public bool updatePatrocinador(Patrocinador patrocinador);
        public IEnumerable<Patrocinador> listPatrocinadores();
        public List<Patrocinador> listPatrocinadores1();

    }
}