using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTtechapp
{
    public class DatosReporte
    {

        public int idCliente { get; set; }
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string comentario { get; set; }
        public string NombreArticulo { get; set; }
        public double iva { get; set; }
        public double Precio { get; set; }
        public string fechaPago { get; set; }
        public double total { get; set; }
        public double subtotal { get; set; }
        public int totalArticulos { get; set; }


    }
    
}
