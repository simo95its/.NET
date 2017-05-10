using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class OrdineEx : Ordine
    {
        public bool IsInternational { get; set; }

        public override string ToString()
        {
            string temp = "";

            foreach (var i in Dettagli)
                temp += i.ToString();

            return "{ "
                + "Id = " + Id + ", "
                + "Data = " + Data + ", "
                + "IsInternational = " + IsInternational + ", "
                + temp
                + " }"
                ;
        }
    }
}
