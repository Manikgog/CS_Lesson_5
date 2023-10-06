using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Triangle : Shape
    {
        public int length;

        public Triangle(int length)
        {
            this.length = length;
        }

        public override void Show()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == length - 1)
                    {
                        Console.Write("O");
                    }
                    else if (i == length/2 - i)
                    {
                        Console.Write("O");
                    }else if (i == length / 2 + i)
                    {

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


    }
}
