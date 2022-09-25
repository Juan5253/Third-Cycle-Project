using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RDeportista : IRDeportista
    {
        private readonly MyAppContext _appContext;
        public RDeportista(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createDeportista(Deportista deportista)
        {
            bool create = false; 
            try
            {
                this._appContext.Deportistas.Add(deportista);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Deportista searchDeportista(int id)
        {
            Deportista deportista = this._appContext.Deportistas.Find(id);
            return deportista;
        }
        public bool deleteDeportista(int id)
        {
            bool delete = false;
            var dep = this._appContext.Deportistas.Find(id);
            if (dep != null)
            {
                try
                {
                    this._appContext.Deportistas.Remove(dep);
                    this._appContext.SaveChanges();
                    delete = true;
                }
                catch (System.Exception)
                {
                    return delete;
                }
            }
            return delete;
        }
        public bool updateDeportista(Deportista deportista)
        {
            bool update = false;
            var dep = this._appContext.Deportistas.Find(deportista.id);
            if(dep != null)
            {
                try
                {
                    dep.documento = deportista.documento;
                    dep.nombres = deportista.nombres;
                    dep.apellidos = deportista.apellidos;
                    dep.fechaNacimiento = deportista.fechaNacimiento;
                    dep.eps = deportista.eps;
                    dep.rh = deportista.rh;
                    dep.celular = deportista.celular;
                    dep.correo = deportista.correo;
                    dep.residencia = deportista.residencia;
                    this._appContext.SaveChanges();
                    update = true;
                }
                catch (System.Exception)
                {
                    return update;
                }
            }
            return update;
        }
        public IEnumerable<Deportista> listDeportistas()
        {
            return _appContext.Deportistas;
        }
        public List<Deportista> listDeportistas1()
        {
            return _appContext.Deportistas.ToList();
        }
    }
}