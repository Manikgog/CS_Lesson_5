using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class DVD_Disk : Storage
    {
        private int readSpeed;
        private int writeSpeed;
        private bool doubleSided;       // если односторонний, то 0, если двухсторонний 1
        private int memoryVolume;       // объём памяти в Мб
        public DVD_Disk() { }
        public DVD_Disk(string name, string model, int readSpeed, int writeSpeed, bool doubleSided)
            : base(name, model)
        {
            this.readSpeed = readSpeed;
            this.writeSpeed = writeSpeed;
            this.doubleSided = doubleSided;
            if(this.doubleSided == false)
            {
                double m = 4.7 * 1024;
                this.memoryVolume = (int)m;
            }
            if(this.doubleSided == true)
            {
                this.memoryVolume = 9 * 1024;
            }
        }

        public int ReadSpeed
        {
            get { return readSpeed; }
            set { readSpeed = value; }
        }

        public int WriteSpeed
        {
            get { return writeSpeed; }
            set { writeSpeed = value; }
        }

        public bool DoubleSided
        {
            get { return doubleSided; }
            set { doubleSided = value; }
        }

        public override int GetMemory()
        {
            return memoryVolume;
        }

        public override int GetSpeedWrite()
        {
            return this.writeSpeed;
        }

        public override int GetSpeedRead()
        {
            return this.readSpeed;
        }

    }
}
