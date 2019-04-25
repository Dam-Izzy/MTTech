using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTtechapp
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string comentario { get; set; }
        public DateTime fechainstalacion { get; set; }
        public double  clave { get; set; }
        public bool activo { get; set; }
        public bool equipo { get; set; }
    }
}
