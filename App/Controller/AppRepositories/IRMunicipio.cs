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
        public bool crearMunicipio(Municipio municipio);
        public Municipio buscarMunicipio(int id);
        public bool eliminarMunicipio(int id);
        public bool actualizarMunicipio(int id);
        public IEnumerable<Municipio> listarMunicipios();
        public List<Municipio> listarMunicipios1();
    }
}