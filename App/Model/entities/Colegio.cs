using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Colegio
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo NIT es obligatorio")]
        [MaxLength(12,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nit { get; set; }
        [Required(ErrorMessage="El campo Razon Social es obligatorio")]
        [MaxLength(30,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(8,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string razonSocial { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string telefono { get; set; }
        [Required(ErrorMessage="El campo Ciudad es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public List<Juez> jueces { get; set; }
    }
}