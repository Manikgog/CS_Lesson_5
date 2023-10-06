using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal abstract class Storage
    {
        protected string name;
        protected string model;

        public Storage() { }
        public Storage(string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public string Model
        {
            get => this.model;
            set => this.model = value;
        }

        public abstract int GetMemory();
        public abstract int GetSpeedWrite();
        public abstract int GetSpeedRead();

    }
}
