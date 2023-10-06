using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Flash : Storage
    {
        private int speedUSB30;
        private int memoryVolume;

        public Flash() { }
        public Flash(string name, string model, int speed, int memoryVolume)
            : base(name, model)
        {
            this.speedUSB30 = speed;
            this.memoryVolume = memoryVolume;
        }

        public override int GetMemory()
        {
            return this.memoryVolume;
        }

        public override int GetSpeedWrite()
        { 
            return this.speedUSB30;
        }

        public override int GetSpeedRead()
        {
            return this.speedUSB30;
        }

    }
}
