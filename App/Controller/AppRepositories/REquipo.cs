using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class REquipo : IREquipo
    {
        private readonly MyAppContext _appContext;
        public REquipo(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createEquipo(Equipo equipo)
        {
            bool create = false; 
            try
            {
                this._appContext.Equipos.Add(equipo);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Equipo searchEquipo(int id)
        {
            Equipo equipo = this._appContext.Equipos.Find(id);
            return equipo;
        }
        public bool deleteEquipo(int id)
        {
            bool delete = false;
            var equi = this._appContext.Equipos.Find(id);
            if (equi != null)
            {
                try
                {
                    this._appContext.Equipos.Remove(equi);
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
        public bool updateEquipo(Equipo equipo)
        {
            bool update = false;
            var equi = this._appContext.Equipos.Find(equipo.id);
            if(equi != null)
            {
                try
                {
                    equi.nombre = equipo.nombre;
                    equi.disciplina = equipo.disciplina;
                    equi.categoria = equipo.categoria;
                    equi.ciudad = equi.ciudad;
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
        public IEnumerable<Equipo> listEquipos()
        {
            return _appContext.Equipos;
        }
        public List<Equipo> listquipos1()
        {
            return _appContext.Equipos.ToList();
        }
    }
}