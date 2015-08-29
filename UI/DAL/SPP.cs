using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SPP
    {
        /**
         * Propiedades
         */
        public String Name { get; set; }
        public String Value { get; set; }

        /**
         * Constructor del Store Procedure Parameter
         */
        public SPP(String name, String value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
