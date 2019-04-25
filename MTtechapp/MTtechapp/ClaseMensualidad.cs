using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTtechapp
{
    public class ClaseMensualidad: Municipio
    {
        public int id { get; set; }
        public string fechaMensualidad { get; set; }
        public double monto { get; set; }
    }
}
