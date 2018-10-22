using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    class Fahrenheit
    {
        public float Degrees { get; }

        public Fahrenheit(float temp)
        {
            Degrees = temp;
        }

        public static explicit operator Celsius(Fahrenheit fahrenhiet)
        {
            //    return new Celsius((5.0f / 9.0f) * (fahr.Degrees - 32));
            return new Celsius(33);
        }


        //public static explicit operator Celsius(Fahrenheit fahr)
        //{
        //    return new Celsius((5.0f / 9.0f) * (fahr.Degrees - 32));
        //}
    }
}
