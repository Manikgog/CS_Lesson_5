using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class SystemBlock
    {
        private Storage[] storage;  // массив носителей информации
        private int size;           // количество заполненных элементов массива
        private int capacity;       // общее количество элементов массива

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

        // метод для получения общего объёма съёмных носителей информации
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

        // метод для вычисления времени, которое необходимо для заполнения памяти 
        // всех подключённых устройств
        public float TimeToCopyToAllStorages()      // время для записи на все устройства
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

        // метод для подсчёта количества носителей информации для копирования файлов с размером oneFileSize
        // c суммарным объёмом volumeOfDataToCopy на носители, в виде объектов классов
        // RemovableHDD, Flash, DVD_disk, которые находятся в массиве storage
        public int NumbersOfStoragesToCopy(int volumeOfDataToCopy, int oneFileSize)
        {
            int numberOfStorages = 0;   // количество носителей информации
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == null)
                {
                    return numberOfStorages;
                }
                // метод внутри скобок while проверяет наличие места на диске для записи 
                // одного файла и возвращает true или false
                while (storage[i].RecordToStorage(oneFileSize))
                {
                    
                    volumeOfDataToCopy -= oneFileSize;
                    // условие остановки записи в случае записи всех файлов,
                    // когда объём информации для записи закончился
                    if (volumeOfDataToCopy <= 0)
                    {
                        break;
                    }
                }
                numberOfStorages++;
            }
            return numberOfStorages;
        }

        // метод для подсчёта времени для копирования файлов с размером oneFileSize
        // c суммарным объёмом volumeOfDataToCopy на носители, в виде объектов классов
        // RemovableHDD, Flash, DVD_disk, которые находятся в массиве storage
        public float TimeToCopyToStorages(int volumeOfDataToCopy, int oneFileSize)
        {
            if (volumeOfDataToCopy > GetOverallVolume())
            {
                Console.WriteLine("Не хватает памяти.");
                return 0;
            }
            float timeToCopy = 0;
            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == null)
                {
                    return timeToCopy;
                }
                // метод внутри скобок while проверяет наличие места на диске для записи 
                // одного файла и возвращает true или false
                while (storage[i].RecordToStorage(oneFileSize))
                {
                    // время, которое затрачивается на запись одного файла на i-тый носитель информации
                    timeToCopy += (float)oneFileSize / storage[i].GetSpeedWrite();
                    // уменьшение, исходного объёма информации на размер файла
                    volumeOfDataToCopy -= oneFileSize;
                    // условие остановки записи в случае записи всех файлов,
                    // когда объём информации для записи закончился
                    if(volumeOfDataToCopy <= 0)
                    {
                        break;
                    }
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

        public void ClearMemoryOfAllStorages()
        {
            for(int i = 0; i < storage.Length; i++)
            {
                if (storage[i] != null)
                {
                    storage[i].ClearMemoryStorage();
                }
                else
                {
                    break;
                }
            }
        }

    }
}
