using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RColegio : IRColegio
    {
        private readonly MyAppContext _appContext;
        public RColegio(MyAppContext RappContext) //the constructor is instantiated by receiving a context
        {
            this._appContext=RappContext;
        }
        public bool createColegio(Colegio colegio)
        {
            bool create = false;
            try
            {
                this._appContext.Colegios.Add(colegio);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Colegio searchColegio(int id)
        {
            Colegio colegio = this._appContext.Colegios.Find(id);
            return colegio;
        }
        public bool deleteColegio(int id)
        {
            bool delete = false;
            var col = this._appContext.Colegios.Find(id);
            if (col != null)
            {
                try
                {
                    this._appContext.Colegios.Remove(col);
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
        public bool updateColegio(Colegio colegio)
        {
            bool update = false;
            var col = this._appContext.Colegios.Find(colegio.id);
            if(col != null)
            {
                try
                {
                    col.nit = colegio.nit;
                    col.razonSocial = colegio.razonSocial;
                    col.telefono = colegio.telefono;
                    col.ciudad = colegio.ciudad;
                    col.direccion = colegio.direccion;
                    this._appContext.SaveChanges();
                }
                catch (System.Exception)
                {
                    return update;
                }
            }
            return update;
        }
        public IEnumerable<Colegio> listColegios()
        {
            return _appContext.Colegios;
        }
        public List<Colegio> listColegios1()
        {
            return _appContext.Colegios.ToList();
        }
    }
}