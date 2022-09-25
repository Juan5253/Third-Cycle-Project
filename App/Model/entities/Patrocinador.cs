using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.entities
{
    public class Patrocinador
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Documento es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string documento { get; set; }
        [Required(ErrorMessage="El campo Tipo Persona es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string tipoPersona { get; set; }
        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombre { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string telefono { get; set; }
        public string correo { get; set; }
        public List<Equipo> equipos { get; set; }
    }
}