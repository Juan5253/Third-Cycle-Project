using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Juez
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Documento es obligatorio")]
        [MaxLength(19,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(9,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string documento { get; set; }
        [Required(ErrorMessage="El campo Nombres es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombres { get; set; }
        [Required(ErrorMessage="El campo Apellidos es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string apellidos { get; set; }
        public string genero { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string celular { get; set; }
        public string correo { get; set; }
        public int torneoId { get; set; }
        public int colegioId { get; set; }

    }
}