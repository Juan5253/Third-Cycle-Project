using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RTorneo : IRTorneo
    {
        private readonly MyAppContext _appContext;
        public RTorneo(MyAppContext RappContext) //the constructor is instantiated by receiving a context
        {
            this._appContext=RappContext;
        }
        public bool createTorneo(Torneo torneo)
        {
            bool create = false; 
            try
            {
                this._appContext.Torneos.Add(torneo);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Torneo searchTorneo(int id)
        {
            Torneo torneo = this._appContext.Torneos.Find(id);
            return torneo;
        }
        public bool deleteTorneo(int id)
        {
            bool delete = false;
            var col = this._appContext.Torneos.Find(id);
            if (col != null)
            {
                try
                {
                    this._appContext.Torneos.Remove(col);
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
        public bool updateTorneo(Torneo torneo)
        {
            bool update = false;
            var tor = this._appContext.Torneos.Find(torneo.id);
            if(tor != null)
            {
                try
                {
                    tor.nombre = torneo.nombre;
                    tor.categoria = torneo.categoria;
                    tor.disciplina = torneo.disciplina;
                    tor.fechaInicial = torneo.fechaInicial;
                    tor.fechaFinal = torneo.fechaFinal;
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
        public IEnumerable<Torneo> listTorneos()
        {
            return _appContext.Torneos;
        }
        public List<Torneo> listTorneos1()
        {
            return _appContext.Torneos.ToList();
        }
    }
}