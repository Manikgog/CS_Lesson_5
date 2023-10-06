using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class SystemBlock
    {
        private Storage[] storage;
        private int size;
        private int capacity;

        public SystemBlock()
        {
            this.capacity = 10;
            this.storage = new Storage[capacity];
            this.size = 0;
        }

        public SystemBlock(int capacity)
        {
            this.capacity = capacity;
            this.storage = new Storage[capacity];
            this.size = 0;
        }

        public int GetOverallVolume()
        {
            int overallVolume = 0;
            for(int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == null)
                {
                    return overallVolume;
                }
                overallVolume += storage[i].GetMemory();
            }
            return overallVolume;
        }

        public float CopyAllStorages()      // время для записи на все устройства
        {
            float timeToCopy = 0;
            for(int i = 0; i < storage.Length;i++)
            {
                if (storage[i] == null)
                {
                    return timeToCopy;
                }
                timeToCopy += (float)storage[i].GetMemory() / storage[i].GetSpeedWrite();
            }
            return timeToCopy;
        }

        public int NumbersOfStoragesToCopy(int volumeOfDataToCopy)
        {
            int numberOfStorages = 0;
            while(volumeOfDataToCopy > 0)
            {
                if (numberOfStorages > size - 1)
                {
                    return -1;      // Не хватило памяти
                }
                volumeOfDataToCopy = volumeOfDataToCopy - storage[numberOfStorages].GetMemory();
                numberOfStorages++;
            }
            return numberOfStorages;
        }

        public float TimeToCopyToStorages(int volumeOfDataToCopy)
        {
            if (volumeOfDataToCopy > GetOverallVolume())
            {
                Console.WriteLine("Не хватает памяти.");
            }
            float timeToCopy = 0;
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == null)
                {
                    return timeToCopy;
                }
                if(volumeOfDataToCopy >= storage[i].GetMemory())
                {
                    timeToCopy += (float)storage[i].GetMemory() / storage[i].GetSpeedWrite();
                    volumeOfDataToCopy -= storage[i].GetMemory();
                }
                else
                {
                    timeToCopy += volumeOfDataToCopy / storage[i].GetSpeedWrite();
                }
            }
            return timeToCopy;
        }

        public void PushBack(Storage st)
        {
            if (size == capacity)
            {
                return;         // места нет
            }
            for (int i = 0; i < storage.Length; i++)
            {

                if (storage[i] != null)
                {
                    continue;
                }
                else
                {
                    storage[i] = st;
                    size++;
                    break;
                }
            }
        }

    }
}
