﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class OrdineDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return "{ "
                + "Id = " + Id + ", "
                + "Data = " + Data
                + " }"
                ;
        }
    }
}
