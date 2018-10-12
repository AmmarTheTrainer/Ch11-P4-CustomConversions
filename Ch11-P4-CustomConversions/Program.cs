using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****\n");


            #region Recall: Numerical Conversions

            //int a = 123;
            //long b = a; // Implicit conversion from int to long.
            //int c = (int)b; // Explicit conversion from long to int.

            #endregion

            #region Conversions Among Related Class Types

            //// Implicit cast between derived to base.
            //Base myBaseType;
            //myBaseType = new Derived();
            //// Must explicitly cast to store base reference
            //// in derived type.
            //Derived myDerivedType = (Derived)myBaseType;

            #endregion

            //// Make a Rectangle.
            //Rectangle r = new Rectangle(15, 4);
            //Console.WriteLine(r.ToString());
            //r.Draw();
            //Console.WriteLine();
            //// Convert r into a Square,
            //// based on the height of the Rectangle.
            //Square s = (Square)r; // Method is invoked here
            //Console.WriteLine(s.ToString());
            //s.Draw();

            //// Convert Rectangle to Square to invoke method.
            //Rectangle rect = new Rectangle(10, 5);
            //Square.DrawSquare((Square)rect);

            #region Additional Explicit Conversions for the Square Type

            //// Converting an int to a Square.
            //Square sq2 = (Square)90;
            //Console.WriteLine("sq2 = {0}", sq2);
            //// Converting a Square to an int.
            //int side = (int)sq2;
            //Console.WriteLine("Side length of sq2 = {0}", side);

            #endregion

            #region Defining Implicit Conversion Routines

            Square s3 = new Square { Length = 83 };
            // Attempt to make an implicit cast?
            //Rectangle rect2 = s3;
            Rectangle rect2 = (Rectangle)s3;

            Console.WriteLine(rect2);

            #endregion

            Console.ReadLine();

        }
    }
}
