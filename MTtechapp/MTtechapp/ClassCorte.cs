using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTtechapp
{
    public class ClassCorte
    {
        public int IdIngreso { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Lugar { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public ClassCorte(){}
        public ClassCorte(ClassCorte Corte)
        {
            this.IdIngreso = Corte.IdIngreso;
            this.Tipo = Corte.Tipo;
            this.Descripcion = Corte.Descripcion;
            this.Lugar = Corte.Lugar;
            this.Monto = Corte.Monto;
            this.Fecha = Corte.Fecha;
            this.Estado = Corte.Estado;
        }

    }    
}
