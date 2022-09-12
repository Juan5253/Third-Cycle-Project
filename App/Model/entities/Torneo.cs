using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Torneo
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage="El campo Categoria es obligatorio")]
        [MaxLength(15,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(4,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string categoria { get; set; }
        [Required(ErrorMessage="El campo Disciplina es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string disciplina { get; set; }
        [Required(ErrorMessage="El campo Fecha Inicial es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime fechaInicial { get; set; }
        [Required(ErrorMessage="El campo Fecha Inicial es obligatorio")] 
        [DataType(DataType.Date)]
        public DateTime fechaFinal { get; set; }
        public int municipioId { get; set; }
        public List<Juez> jueces { get; set; }
    }
}