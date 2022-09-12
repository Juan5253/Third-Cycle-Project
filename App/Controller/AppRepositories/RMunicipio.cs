using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RMunicipio: IRMunicipio //The RMunicipio class is in charge of providing functionality (implementation), to the methods signed in the interface IRMunicipio
    {
        //Attribute
        private readonly MyAppContext _appContext;
        //Methods
        //Transactions are executed in the database with the execution of each methods   
        public RMunicipio(MyAppContext RappContext) //the constructor is instantiated by receiving a context
        {
            this._appContext=RappContext;
        }
        public bool crearMunicipio(Municipio municipio) //the method crearMunicipio() receives an attribute calls municipio with type of data object Municipio
        {
            bool create = false; //invalid
            return create;
        }
        public Municipio buscarMunicipio(int id)
        {
            Municipio municipio =null; //invalid
            return municipio;   
        }
        public bool eliminarMunicipio(int id)
        {
            bool delete = false; //invalid
            return delete;
        }
        public bool actualizarMunicipio(int id)
        {
            bool update = false;  //invalid
            return update;
        }
        public IEnumerable<Municipio> listarMunicipios() //IEnumerable is like a List 
        {
            return _appContext.Municipios; //Done
        }
        public List<Municipio> listarMunicipios1()
        {
            return _appContext.Municipios.ToList(); //Done
        }
    }
}