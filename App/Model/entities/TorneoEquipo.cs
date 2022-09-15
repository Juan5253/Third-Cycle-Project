using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class TorneoEquipo
    {
        public int id { get; set; }
        public int torneoId { get; set; }
        public int equipoId { get; set; }
        public Torneo torneo { get; set; }
        public Equipo equipo { get; set; }
    }
}