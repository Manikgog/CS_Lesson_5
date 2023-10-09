using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle(int width, int height, byte color) : base(color) 
        {
            this.width = width;
            this.height = height;
        }

        public override void Show()
        {
            SetColor();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write("O ");
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
    }
}


