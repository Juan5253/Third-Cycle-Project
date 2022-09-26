using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class REntrenador : IREntrenador
    {
        private readonly MyAppContext _appContext;
        public REntrenador(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createEntrenador(Entrenador Entrenador)
        {
            bool create = false; 
            try
            {
                this._appContext.Entrenadores.Add(Entrenador);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Entrenador searchEntrenador(int id)
        {
            Entrenador entrenador = this._appContext.Entrenadores.Find(id);
            return entrenador;
        }
        public bool deleteEntrenador(int id)
        {
            bool delete = false;
            var ent = this._appContext.Entrenadores.Find(id);
            if (ent != null)
            {
                try
                {
                    this._appContext.Entrenadores.Remove(ent);
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
        public bool updateEntrenador(Entrenador entrenador)
        {
            bool update = false;
            var ent = this._appContext.Entrenadores.Find(entrenador);
            if (ent != null)
            {
                try
                {
                    ent.documento = entrenador.documento;
                    ent.nombres = entrenador.nombres;
                    ent.apellidos = entrenador.apellidos;
                    ent.genero = entrenador.genero;
                    ent.celular = entrenador.celular;
                    ent.correo = entrenador.correo;
                    ent.nacionalidad = entrenador.nacionalidad;
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
        public IEnumerable<Entrenador> listEntrenadores()
        {
            return _appContext.Entrenadores;
        }
        public List<Entrenador> listEntrenadores1()
        {
            return _appContext.Entrenadores.ToList();
        }
    }
}