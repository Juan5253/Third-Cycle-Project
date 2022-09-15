using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.entities
{
    public class Equipo
    {
        public int id { get; set; }
        [Required(ErrorMessage="El campo Nombre es obligatorio")]
        [MaxLength(35,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string nombre { get; set; }
        [Required(ErrorMessage="El campo Disciplina es obligatorio")]
        [MaxLength(35,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(6,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string disciplina { get; set; }
        [Required(ErrorMessage="El campo Categoria es obligatorio")]
        [MaxLength(20,ErrorMessage="El campo {0} no puede tener más de {1} caracteres")]
        [MinLength(5,ErrorMessage="El campo {0} no puede tener menos de {1} caracteres")]
        public string categoria { get; set; }
        public string ciudad { get; set; }
        public Entrenador entrenador { get;  set; }
        public List<TorneoEquipo> torneoEquipo { get; set; }
        public List<Deportista> deportista { get; set; }
        public int patrocinadorId { get; set; }
    }
}