using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class RangeOfArray
    {
        private int subscript;
        private int superscript;
        private int[] array;

        public RangeOfArray()
        {
            this.subscript = 0;
            this.superscript = 0;
        }

        public RangeOfArray(int subscript, int superscript)
        {
            if (subscript < superscript)
            {
                this.subscript = subscript;
                this.superscript = superscript;
            }
            else if (subscript > superscript)
            {
                this.subscript = superscript;
                this.superscript = subscript;
            }
            array = new int[this.superscript - this.subscript];
        }

        private int NormalizeIndex(int index)
        {
            if(index < this.subscript || index >= this.superscript)
            {
                return 0;
            }
            int standartIndex = 0;
            for(int i = this.subscript; i < this.superscript; i++)
            {
                if(i == index)
                {
                    break;
                }
                standartIndex++;
            }
            return standartIndex;
        }

        public int Subscript
        {
            get { return this.subscript; }
        }

        public int Superscript
        {
            get { return this.superscript; }
        }

        public int this[int index] 
        { 
            get 
            { 
                return array[NormalizeIndex(index)]; 
            } 
            set 
            { 
                array[NormalizeIndex(index)] = value; 
            } 
        }

        public int[] Array
        {
            get { return array; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for(int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i].ToString());
                if(i == array.Length - 1)
                {
                    continue;
                }
                sb.Append(", ");
            }
            sb.Append("]");
            return sb.ToString();
        }

    }
}
