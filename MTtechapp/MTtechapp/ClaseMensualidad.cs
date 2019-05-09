using System;
namespace MTtechapp
{
    public class ClaseMensualidad: Municipio
    {
        public int id { get; set; }
        public string fechaMensualidad { get; set; }
        public double monto { get; set; }
    }
}
