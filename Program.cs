using System;

namespace LabWork2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть студентiв: ");
            int amountOfStudents = Convert.ToInt32(Console.ReadLine());
            string f;
            int v;
            int o;
            int vSum = 0;
            int oSum = 0;
            int p1Sum = 0;
            //Створення масиву об'єктів
            SecondName[] ArrayOfObjects = new SecondName[amountOfStudents];
            for (int i = 0; i < amountOfStudents; i++)
            {
                //Одержання інформації про студентів з консолі
                Console.Write($"Введiть прiзвище {i+1}-го студента: ");
                f = Console.ReadLine();
                Console.Write($"Введiть загальну кiлькiсть пропущених {i + 1}-им студентом годин: ");
                v = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Введiть кiлькiсть пропущених {i + 1}-им студентом годин (виправдано): ");
                o = Convert.ToInt32(Console.ReadLine());
                if (o>v)
                {
                    Console.WriteLine("Кiлькiсть прогуляних годин не може бути вiд'ємною");
                    break;
                }
                ArrayOfObjects[i] = new SecondName(f, v, o);
            }
            for (int i = 0; i < amountOfStudents; i++)
            {
                //Обчислення загальної кількості пропусків всіх студентів
                vSum += ArrayOfObjects[i].V;
                oSum += ArrayOfObjects[i].O;
                p1Sum += ArrayOfObjects[i].P1;
            }
            //Вивід заголовка таблиці в консоль
            Console.WriteLine();
            Console.WriteLine(" №\t    Прiзвище\t\tПропущено, год.\t\t\tПропуск\t\t");
            Console.WriteLine(" з/п\t\t\t\tусього\tвиправдано\tу годинах\tу %\t");
            Console.WriteLine();
            //Вивід інформації в консоль
            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine($" {i+1,4} {ArrayOfObjects[i].F,18} {ArrayOfObjects[i].V,13} " +
                    $"{ArrayOfObjects[i].O,11} {ArrayOfObjects[i].P1,14} {ArrayOfObjects[i].P2,9}");
            }
            //Вивід суми годин
            Console.WriteLine($"\t    Разом:{vSum,20} {oSum,11} {vSum,14}");
        }
    }
}
