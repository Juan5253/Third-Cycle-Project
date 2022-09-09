using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Municipio
    {
        //Attributes
        private int id;
        private string nombre;
        private string secretaria;
        //Methods
        public Municipio()
        {}
        public void setId (int id)
        {
            this.id=id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setNombre (int nombre)
        {
            this.nombre=nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setSecretaria (int secretaria)
        {
            this.secretaria=secretaria;
        }
        public string getSecretaria()
        {
            return this.secretaria;
        }
    }
}