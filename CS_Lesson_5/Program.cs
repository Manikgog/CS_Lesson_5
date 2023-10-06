using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DVD_Disk dvd_1 = new DVD_Disk("Sony", "WalkMan", 10, 2, false);
            //Flash flash_1 = new Flash("RedStone", "RS_1", 10, 32);
            //RemovableHDD removableHDD_1 = new RemovableHDD("Samsung", "S_1", 20, 50, 20);

            //SystemBlock sb = new SystemBlock();

            //sb.PushBack(dvd_1);
            //sb.PushBack(flash_1);
            //sb.PushBack(removableHDD_1);
            //int memoryToCopy = 100;
            //Console.WriteLine("Количество устройств для записи - " + sb.NumbersOfStoragesToCopy(1000));
            //Console.WriteLine("Время для заполнения памяти всех устройств - " + sb.CopyAllStorages());
            //Console.WriteLine("Время для записи " + memoryToCopy + " Mb - " + sb.TimeToCopyToStorages(memoryToCopy));

            //Rectangle r = new Rectangle(40, 30);
            //r.Show();

            Triangle t = new Triangle(10);
            t.Show();


        }
    }
}
