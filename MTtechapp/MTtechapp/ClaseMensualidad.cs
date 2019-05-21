using System;
namespace MTtechapp
{
    public class ClaseMensualidad
    {
        public int id { get; set; }
        public DateTime fechaMensualidad { get; set; }
        public double monto { get; set; }
        public int idMensualidades { get; set; }
        public string NombreCompleto { get; set; }
        public string direccion { get; set; }
        public DateTime mesprox { get; set; }
        public DateTime Enero { get; set; }
        public DateTime Febrero { get; set; }
        public DateTime Marzo { get; set; }
        public DateTime Abril { get; set; }
        public DateTime Mayo { get; set; }
        public DateTime Junio { get; set; }
        public DateTime Julio { get; set; }
        public DateTime Agosto { get; set; }
        public DateTime Septiembre { get; set; }
        public DateTime Octubre { get; set; }
        public DateTime Noviembre { get; set; }
        public DateTime Diciembre { get; set; }
        public string nombre { get; set; }
        public string Comentario { get; set; }
        public Cliente cliente = new Cliente();       
        public Municipio municipio = new Municipio();     
    }
}
