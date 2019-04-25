using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTtechapp
{
   public class Clasedatosinformepago
    {       
        public String NombreCompleto { get; set; }
        public String domicilio { get; set; }
        public String telefono { get; set; }
        public int cantidad { get; set; }
        public String nombreArticulo { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public String Sfolio  { get; set; }
        public double valor { get; set; }
        internal List<Clasedatosinformepago> clasedatosinformepagos = new List<Clasedatosinformepago>();
        public string GetFolio(string sFolio, int iValor)
        {
            string sChar = "", sNumeros = "0123456789", sFolioNum = "", sASumar = "", sFixBlock = "";
            int iAdd = 0, iSigFol = 0;

            for (int icol = sFolio.Length - 1; icol > 0; icol--)
            {
                sChar = sFolio.Substring(icol, 1);

                if (sNumeros.IndexOf(sChar) == -1)
                {
                    iAdd = icol + 1;
                    break;
                }
            }

            sFixBlock = sFolio.Substring(0, iAdd);
            sASumar = sFolio.Substring(iAdd);

            string sFormat = new string('0', sASumar.Length);

            int.TryParse(sASumar, out iSigFol);
            iSigFol = iSigFol + iValor;
            sFolioNum = sFixBlock + iSigFol.ToString(sFormat);

            return sFolioNum;
        }


    }
}
