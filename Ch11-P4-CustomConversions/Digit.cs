using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    class Digit
    {
        public double val;
        // ...other members

        public Digit(double d) // Consructor
        {
            val = d;
        }

        public static implicit operator double(Digit d)
        {
            return d.val;
        }

        public static implicit operator Digit(double d)
        {
            return new Digit(d);
        }
       
        ////  User-defined conversion from double to Digit
        //public static implicit operator Digit(double d)
        //{
        //    return new Digit(d);
        //}
    }
}
