using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Municipio
    {   
        //Use of Entity Framework
        public int id { get; set; }
        public string nombre { get; set; }
        public string secretaria { get; set; }
        /*
        //OOP Native
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
        */
    }
}