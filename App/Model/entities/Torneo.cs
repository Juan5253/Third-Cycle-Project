using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Torneo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string disciplina { get; set; }
        public DateTime fechaInicial { get; set; } 
        public DateTime fechaFinal { get; set; }
        public int municipioId { get; set; }
        public List<Juez> jueces { get; set; }
    }
}