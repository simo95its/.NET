using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class DettaglioOrdine
    {
        public int Id { get; set; }
        public int Prezzo { get; set; }
        public int Quantita { get; set; }

        public override string ToString()
        {
            return "{ "
                + "Id = " + Id + ","
                + "Prezzo = " + Prezzo + ","
                + "Quantita = " + Quantita
                + " }"
                ;
        }
    }
}
