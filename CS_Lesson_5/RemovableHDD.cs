using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class RemovableHDD : Storage
    {
        private int speedUSB20;
        private int numbersOfSections;
        private int sectionVolume;
        private int memoryVolume;
        private int busyMemory = 0;

        public RemovableHDD() { }
        public RemovableHDD(string name, string model,
                            int speed, int numberOfSections, int sectionVolume)
            : base(name, model) 
        {
            this.speedUSB20 = speed;
            this.numbersOfSections = numberOfSections;
            this.sectionVolume = sectionVolume;
            this.memoryVolume = numberOfSections * sectionVolume;
        }

        public override int GetMemory()
        {
            return this.memoryVolume;
        }

        public override int GetSpeedWrite()
        {
            return this.speedUSB20;
        }

        public override int GetSpeedRead()
        {
            return this.speedUSB20;
        }

        public override bool RecordToStorage(int fileSize)
        {
            if (fileSize <= this.memoryVolume - this.busyMemory)
            {
                busyMemory += fileSize;
                return true;
            }
            return false;
        }

        public override void ClearMemoryStorage()
        {
            busyMemory = 0;
        }

    }
}
