﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Triangle : Shape
    {
        public int length;

        public Triangle(int length, byte color) : base(color)
        {
            this.length = length;
        }

        public override void Show()
        {
            SetColor();
            for (int i = 0; i < length/2 + 1; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == length/2)
                    {
                        Console.Write("O ");
                    }
                    else if (j == length/2 - i || j == length / 2 + i)
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
