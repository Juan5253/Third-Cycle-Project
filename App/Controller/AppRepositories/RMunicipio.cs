using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RMunicipio : IRMunicipio //The RMunicipio class is in charge of providing functionality (implementation), to the methods signed in the interface IRMunicipio
    {
        //Attribute
        private readonly MyAppContext _appContext; //The brigde between RMunicipio and MyAppContext
        //Methods
        //Transactions are executed in the database with the execution of each methods   
        public RMunicipio(MyAppContext RappContext) //the constructor is instantiated by receiving a context
        {
            this._appContext=RappContext; //Done 
        }
        ///CRUD OPERATIONS 
        public bool createMunicipio(Municipio municipio) //the method crearMunicipio() receives an attribute calls municipio with type of data object Municipio
        {
            bool create = false; // Control Varible 
            try //Exception Handling 
            {
                this._appContext.Municipios.Add(municipio);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                create = false;
            } 
            return create; // Done 
        }
        public Municipio searchMunicipio(int id)
        {
            Municipio municipio = this._appContext.Municipios.Find(id); 
            return municipio;   // Done
        }
        public bool deleteMunicipio(int id)
        {
            bool delete = false;
            var mun = this._appContext.Municipios.Find(id);
            if(mun != null)
            {
                try
                {
                    this._appContext.Municipios.Remove(mun);
                    this._appContext.SaveChanges();
                    delete = true;
                }
                catch (System.Exception)
                {
                    delete = false;
                } 
            }
            return delete; //Done 
        }
        public bool updateMunicipio(Municipio municipio)
        {
            bool update = false;
            var mun = this._appContext.Municipios.Find(municipio.id);
            if(mun != null)
            {
                try
                {
                    //Attributes of Municipio Object
                    mun.nombre = municipio.nombre;
                    mun.secretaria = municipio.secretaria;
                    this._appContext.SaveChanges();
                    update = true;
                }
                catch (System.Exception)
                {
                    update = false;
                }
            }
            return update; //Done
        }
        public IEnumerable<Municipio> listMunicipios() //IEnumerable is like a List 
        {
            return _appContext.Municipios; //Done
        }
        public List<Municipio> listMunicipios1()
        {
            return _appContext.Municipios.ToList(); //Done
        }
    }
}