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
            //Task_1();

            Task_2();

            //Task_3();

        }

        public static void Task_1()
        {
            /*
            Задание 1.
        В С # индексация начинается с нуля, но в некоторых
        языках программирования это не так. Например, в Turbo
        Pascal индексация массиве начинается с 1. Напишите класс
        RangeOfArray, который позволяет работать с массивом 
        такого типа, в котором индексный диапазон устанавливается 
        пользователем. Например, в диапазоне от 6 до 10,
        или от –9 до 15.
            */

            int subscript = -9;     // нижняя граница индексного диапазона
            int superscript = 15;   // верхняя граница индексного диапазона
            RangeOfArray rangeOfArray = new RangeOfArray(subscript, superscript);
            for(int i = subscript, j = 1; i < superscript; i++, j++)
            {
                rangeOfArray[i] = j;
            }
            Console.WriteLine(rangeOfArray.ToString());
        }

        public static void Task_2()
        {
            /*
            Задание 1. Разработать приложение «Резервная копия»
        Цель: произвести расчет необходимого количества внешних 
        носителей информации при переносе за один раз
        важной информации (565 Гб, файлы по 780 Мб) с рабочего
        компьютера на домашний компьютер и затрачиваемое
        на данный процесс время. Вы имеете в распоряжении
        следующие типы носителей информации:
        ■ Flash-память,
        ■ DVD-диск,
        ■ съемный HDD.
            Каждый носитель информации является объектом соответствующего класса:
        ■ Flash-память — класс «Flash»;
        ■ класс DVD-диск — класс «DVD»;
        ■ класс съемный HDD — класс «HDD».
            Все три класса являются производными от абстрактного
        класса «Носитель информации» — класс «Storage».
        Базовый класс («Storage») содержит следующие закрытые
        поля:
        ■ наименование носителя;
        ■ модель.
            Класс обладает всеми необходимыми свойствами для
        доступа к полям, а также абстрактными методами:
        ■ получение объема памяти;
        ■ копирование данных (файлов/папок) на устройство,
        ■ получение информации о свободном объеме памяти
        на устройстве;
        ■ получение общей/полной информации об устройстве.
            Кроме того, каждый из производных классов дополняется
        следующими полями:
        ■ класс Flash-память: скорость USB 3.0, объем памяти;
        ■ класс DVD-диск: скорость чтения / записи, тип
        (односторонний (4.7 Гб) /двусторонний (9 Гб));
        ■ класс съемный HDD: скорость USB 2.0, количество
        разделов, объем разделов.
            Работа с объектами соответствующих классов производится 
        через ссылки на базовый класс («Storage»), которые
        хранятся в массиве.
            Приложение должно предоставлять следующие возможности:
        ■ расчет общего количества памяти всех устройств;
        ■ копирование информации на устройства;
        ■ расчет времени необходимого для копирования;
        ■ расчет необходимого количества носителей информации представленных типов для переноса
        информации.
             */
            int readSpeedDVD = 44;          // скорость чтения DVD диска в Мб/с
            int writeSpeedDVD = 11;         // скорость записи на DVD диск в Мб/с
            bool doubleSided = false;       // односторонний диск если false, двухсторонний если true
            int readWriteSpeedFlash = 600;  // скорость чтения/записи Flash носителя в Мб/с (USB 3.0)
            int sizeOfMemoryFlash = 64000;  // объём памяти Flash носителя в Мб
            int readWriteSpeedHDD = 60;     // скорость чтения/записи HDD носителя в Мб/с (USB 2.0)
            int numberOfSections = 512;     // количество секторов
            int sectionVolume = 1024;       // размер одного сектора в Мб

                                            //name, model,  readSpeed, writeSpeed, doubleSided
            DVD_Disk dvd_1 = new DVD_Disk("Sony", "WalkMan", readSpeedDVD, writeSpeedDVD, doubleSided);

                                      //name, model, readWriteSpeed, memeryVolume
            Flash flash_1 = new Flash("RedStone", "RS_1", readWriteSpeedFlash, sizeOfMemoryFlash);

                                                            //name, model, speed, numberOfSections, sectionVolume 
            RemovableHDD removableHDD_1 = new RemovableHDD("Samsung", "S_1", readWriteSpeedHDD, numberOfSections, sectionVolume);

            SystemBlock sb = new SystemBlock(); // объект класса SystemBlock

            sb.PushBack(dvd_1);                 // подключение носителя DVD к системному блоку
            sb.PushBack(flash_1);               // подключение носителя Flash к системному блоку
            sb.PushBack(removableHDD_1);        // подключение носителя HDD к системному блоку
            int memoryToCopy = 564720;          // 564720 Мб или 724 файла по 780 Мб
            int oneFileSize = 780;
            Console.WriteLine("Суммарный объём всех съёмных носителей - " + sb.GetOverallVolume() + " Мб");
            Console.WriteLine("Количество устройств для записи - " + sb.NumbersOfStoragesToCopy(memoryToCopy, oneFileSize));
            sb.ClearMemoryOfAllStorages();
            Console.WriteLine("Время для заполнения памяти всех устройств - " + sb.TimeToCopyToAllStorages() + " сек.");
            Console.WriteLine("Время для записи " + memoryToCopy + " Mb - " + sb.TimeToCopyToStorages(memoryToCopy, oneFileSize) + " сек.");

        }

        public static void Task_3()
        {
            /*
            Задание 1. Приложение «Фигуры»
        Написать приложение, которое будет отображать в консоли
        выбранные пользователем простейшие геометрические
        фигуры: «прямоугольник», «ромб», «треугольник», «трапеция», 
        «многоугольник». В меню пользователь выбирает
        фигуры и выбирает цвета для каждой фигуры. Фигуры
        рисуются звездочками или другими символами. Для реализации 
        программы необходимо разработать иерархию
        классов (продумать возможность абстрагирования). Все
        заданные пользователем фигуры хранятся в объекте
        «Обобщённая фигура», который имеет метод «отобразить
        все выбранные фигуры».
            */
            
            while (true)
            {
                
                int choice = SelectFigure();
                Console.Clear();
                Shape figure;
                bool quite = false;
                switch (choice)
                {
                    case 1:
                        figure = new Rectangle(5, 8, SelectColor());
                        Console.Clear();
                        figure.Show();
                        break;
                    case 2:
                        figure = new Triangle(15, SelectColor());
                        Console.Clear();
                        figure.Show();
                        break;
                    case 3:
                        figure = new Trapezoid(25, SelectColor());
                        Console.Clear();
                        figure.Show();
                        break;
                    case 4:
                        figure = new Rhomb(15, SelectColor());
                        Console.Clear();
                        figure.Show();
                        break;
                    case 5:
                        figure = new Hexagon(15, SelectColor());
                        Console.Clear();
                        figure.Show();
                        break;
                    default:
                        Console.Clear();
                        quite = true;
                        break;
                }
                if (quite)
                {
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        public static byte SelectFigure()
        {
            byte figure = 0;
            Console.WriteLine("1. Прямоугольник.");
            Console.WriteLine("2. Треугольник.");
            Console.WriteLine("3. Трапеция.");
            Console.WriteLine("4. Ромб.");
            Console.WriteLine("5. Шестиугольник.");
            Console.WriteLine("6. Выход.");
            Console.Write("Введите номер фигуры: ");
            figure = Convert.ToByte(Console.ReadLine());
            return figure;
        }
        public static byte SelectColor()
        {
            Console.WriteLine("Установите цвет фигуры: ");
            Console.WriteLine("1. Красный.");
            Console.WriteLine("2. Оранжевый.");
            Console.WriteLine("3. Жёлтый.");
            Console.WriteLine("4. Зелёный.");
            Console.WriteLine("5. Голубой.");
            Console.WriteLine("6. Синий.");
            Console.WriteLine("7. Фиолетовый.");
            Console.WriteLine("8. Белый.");
            byte color = Convert.ToByte(Console.ReadLine());
            return color;
        }
    }
}
