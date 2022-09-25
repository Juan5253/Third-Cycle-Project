using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.entities
{
    public class Escenario
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Nombres es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(3,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage="El campo Disciplina es obligatorio")]
        [MaxLength(25,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string disciplina { get; set; }
        [Required(ErrorMessage="El campo Capacidad es obligatorio")]
        public int capacidad { get; set; }
        public int instalacionId { get; set; }
    }
}