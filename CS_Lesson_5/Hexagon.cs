using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Hexagon : Shape
    {
        public int length;

        public Hexagon(int length, byte color) : base(color)
        {
            this.length = length;
        }

        public override void Show()
        {
            SetColor();
            for (int i = 0; i < length/3-2; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0  && (j >= length/3 - i && j <= length - length/3 + i))
                    {
                        Console.Write("O");
                    }
                    else if (j == length/4 - i || j == length/2 + length/4 + i)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            
            for (int i = length/4; i >= 0; i--)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0  && (j >= length/3 - i && j <= length - length/3 + i))
                    {
                        Console.Write("O");
                    }
                    else if (j == length/4 - i || j == length/2 + length/4 + i)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
    }
}
