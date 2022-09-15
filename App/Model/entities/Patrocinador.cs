using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Patrocinador
    {
        public int id { get; set; }
        public string documento { get; set; }
        public string tipoPersona { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public List<Equipo> equipos { get; set; }
    }
}