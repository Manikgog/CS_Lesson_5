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
        private int busyMemory=0;
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

        // метод для "записи" файла на носитель
        public override bool RecordToStorage(int fileSize)
        {
            // если размер файла больше размера оставшейся на носителе памяти,
            // то выходим из метода с возвращением false,
            // если меньше, то добавляем размер файла к размер занятой уже памяти
            // на носителе и выходим с возвращением true, т.е. место на носителе ещё есть
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
