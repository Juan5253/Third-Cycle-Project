using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Deportista
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Documento es obligatorio")]
        [MaxLength(10,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(10,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string documento { get; set; }
        [Required(ErrorMessage="El campo Nombres es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombres { get; set; }
        [Required(ErrorMessage="El campo Apellidos es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string apellidos { get; set; }
        [Required(ErrorMessage="El campo Fecha de Nacimiento es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }
        public string eps { get; set; }
        public string rh { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string celular { get; set; }
        public string correo { get; set; }
        public string residencia { get; set; }
        public int equipoID { get; set; }

    }
}