using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RPatrocinador : IRPatrocinador
    {
        private readonly MyAppContext _appContext;
        public RPatrocinador(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createPatrocinador(Patrocinador patrocinador)
        {
            bool create = false;
            try
            {
                this._appContext.Patrocinadores.Add(patrocinador);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            { 
                return create;
            }
            return create;
        }
        public Patrocinador searchPatrocinador(int id)
        {
            Patrocinador patrocinador = this._appContext.Patrocinadores.Find(id);
            return patrocinador;
        }
        public bool deletePatrocinador(int id)
        {
            bool delete = false;
            var pat = this._appContext.Patrocinadores.Find(id);
            if ( pat != null)
            {
                try
                {
                    this._appContext.Patrocinadores.Remove(pat);
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
        public bool updatePatrocinador(Patrocinador patrocinador)
        {
            bool update = false;
            var pat = this._appContext.Patrocinadores.Find(patrocinador);
            if ( pat != null)
            {
                try
                {
                    pat.documento = patrocinador.documento;
                    pat.tipoPersona = patrocinador.tipoPersona;
                    pat.nombre = patrocinador.nombre;
                    pat.telefono = patrocinador.telefono;
                    pat.correo = patrocinador.correo;
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
        public IEnumerable<Patrocinador> listPatrocinadores()
        {
            return _appContext.Patrocinadores;
        }
        public List<Patrocinador> listPatrocinadores1()
        {
            return _appContext.Patrocinadores.ToList();
        }
    }
}