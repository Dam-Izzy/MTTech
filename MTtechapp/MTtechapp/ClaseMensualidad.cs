using System;
namespace MTtechapp
{
    public class ClaseMensualidad
    {
        public int id { get; set; }
        public string fechaMensualidad { get; set; }
        public double monto { get; set; }
        public int idMensualidades { get; set; }
        public Cliente cliente = new Cliente();
        public Municipio municipio = new Municipio();     
    }
}
