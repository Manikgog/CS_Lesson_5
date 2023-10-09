using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal abstract class Shape
    {

        protected byte color;

        public Shape(byte color)
        {
            this.color=color;   // 1 - красный, 2 - оранжевый, 3 - жёлтый, 4 - зелёный, 5 - голубой, 6 - синий, 7 - фиолетовый, 8 - белый
        }

        public void SetColor()
        {
            switch (color)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Red; break;
                case 2: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case 3: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 4: Console.ForegroundColor = ConsoleColor.Green; break;
                case 5: Console.ForegroundColor = ConsoleColor.Cyan;  break;
                case 6: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 7: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 8: Console.ForegroundColor = ConsoleColor.White; break;
            } 
        }

        public abstract void Show();
    }
}
