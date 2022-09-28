using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public interface IRMunicipio //declaration of signed methods, the implementation is done in RMunicipios
    {
        //the argument is packed, it receives all the attributes encapsulated in an object of type Municipio called municipio
        public string createMunicipio(Municipio municipio);
        public Municipio searchMunicipio(int id);
        public bool deleteMunicipio(int id);
        public bool updateMunicipio(Municipio municipio);
        public IEnumerable<Municipio> listMunicipios();
        public List<Municipio> listMunicipios1();
    }
}