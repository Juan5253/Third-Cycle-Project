using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.entities;

namespace Controller.AppRepositories
{
    public class RInstalacion : IRInstalacion
    {
        private readonly MyAppContext _appContext;
        public RInstalacion(MyAppContext RappContext)
        {
            this._appContext=RappContext;
        }
        public bool createInstalacion(Instalacion instalacion)
        {
            bool create = false;
            try
            {
                this._appContext.Instalaciones.Add(instalacion);
                this._appContext.SaveChanges();
                create = true;
            }
            catch (System.Exception)
            {
                return create;
            }
            return create;
        }
        public Instalacion searchInstalacion(int id)
        {
            Instalacion instalacion = this._appContext.Instalaciones.Find(id);
            return instalacion;
        }
        public bool deleteInstalacion(int id)
        {
            bool delete = false;
            var ins = this._appContext.Instalaciones.Find(id);
            if (ins != null)
            {
                try
                {
                    this._appContext.Instalaciones.Remove(ins);
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
        public bool updateInstalacion (Instalacion instalacion)
        {
            bool update = false;
            var ins = this._appContext.Instalaciones.Find(instalacion);
            if(ins != null)
            {
                try
                {
                    ins.nombre = instalacion.nombre;
                    ins.ubicacion = instalacion.ubicacion;
                    ins.capacidad = instalacion.capacidad;
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
        public IEnumerable<Instalacion> listInstalaciones()
        {
            return _appContext.Instalaciones;
        }
        public List<Instalacion> listInstalaciones1()
        {
            return _appContext.Instalaciones.ToList();
        }
    }
}