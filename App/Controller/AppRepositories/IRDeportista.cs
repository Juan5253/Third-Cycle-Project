using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRDeportista
    {
        public bool createDeportista(Deportista deportista);
        public Deportista searchDeportista(int id);
        public bool deleteDeportista(int id);
        public bool updateDeportista(Deportista deportista);
        public IEnumerable<Deportista> listDeportistas();
        public List<Deportista> listDeportistas1();
    }
}