using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.entities
{
    public class Colegio
    {
        public int id { get; set; }
        public string nit { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
    }
}