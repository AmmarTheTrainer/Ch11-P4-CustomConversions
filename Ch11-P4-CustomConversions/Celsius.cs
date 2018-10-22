using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    class Celsius
    {
        public float Degrees { get; }

        public Celsius(float temp)
        {
            Degrees = temp;
        }


        //public static explicit operator Fahrenheit(Celsius c)
        //{
        //    return new Fahrenheit((9.0f / 5.0f) * c.Degrees + 32);
        //}
    }
}
