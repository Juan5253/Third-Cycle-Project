using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Municipio
    {   
        //Use of Entity Framework
        //[key] Primary Key notation
        public int id { get; set; }
        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombre { get; set; }
        [MaxLength(40,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(10,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string secretaria { get; set; }
        public List<Torneo> torneos { get; set; }
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