using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class REscenario
    {
        private readonly MyAppContext _appContext;
        public REscenario(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createEscenario(Escenario escenario)
        {
            bool create = false;
            try
            {
                this._appContext.Escenarios.Add(escenario);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Escenario searchEscenario(int id)
        {
            Escenario escenario = this._appContext.Escenarios.Find(id);
            return escenario;
        }
        public bool deleteEscenario(int id)
        {
            bool delete = false;
            var esc =this._appContext.Escenarios.Find(id);
            if (esc != null)
            {
                try
                {
                    this._appContext.Escenarios.Remove(esc);
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
        public bool updateEscenario(Escenario escenario)
        {
            bool update = false;
            var esc = this._appContext.Escenarios.Find(escenario);
            if (esc != null)
            {
                try
                {
                    esc.nombre = escenario.nombre;
                    esc.disciplina = escenario.disciplina;
                    esc.capacidad = escenario.capacidad;
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
        public IEnumerable<Escenario> listEscenarios()
        {
            return _appContext.Escenarios;
        }
        public List<Escenario> listEscenarios1()
        {
            return _appContext.Escenarios.ToList();
        }
        
    }
}