using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l)
        {
            Length = l;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        // This method requires a Square type.
        public static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
        public override string ToString() => $"[Length = {Length}]";

        // Rectangles can be explicitly converted into Squares.
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square { Length = r.Height };
            return s;
        }

        // Rectangles can be explicitly converted into Squares.
        public static explicit operator Square(int sideLength)
        {
            Square newSq = new Square { Length = sideLength };
            return newSq;
        }

        public static explicit operator int(Square s) => s.Length;
    }
}
