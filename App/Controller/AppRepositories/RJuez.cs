using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RJuez : IRJuez
    {
        private readonly MyAppContext _appContext;
        public RJuez (MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createJuez(Juez juez)
        {
            bool create = false;
            try
            {
                this._appContext.Jueces.Add(juez);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Juez searchJuez(int id)
        {
            Juez juez = this._appContext.Jueces.Find(id);
            return juez;
        }
        public bool deleteJuez(int id)
        {
            bool delete = false;
            var juez = this._appContext.Jueces.Find(id);
            if ( juez != null)
            {
                try
                {
                    this._appContext.Jueces.Remove(juez);
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
        public bool updateJuez (Juez juez)
        {
            bool update = false;
            var ju = this._appContext.Jueces.Find(juez);
            if ( ju != null)
            {
                try
                {
                    ju.documento = juez.documento;
                    ju.nombres = juez.nombres;
                    ju.apellidos = juez.apellidos;
                    ju.genero = juez.genero;
                    ju.celular = juez.celular;
                    ju.correo = juez.correo;
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
        public IEnumerable<Juez> listJueces()
        {
            return _appContext.Jueces;
        }
        public List<Juez> listJueces1()
        {
            return _appContext.Jueces.ToList();
        }
    }
}