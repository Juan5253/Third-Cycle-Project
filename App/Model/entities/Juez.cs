using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Juez
    {
        public int id { get; set; }
        public string documento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public int torneoId { get; set; }
        public int colegioId { get; set; }

    }
}