using System;
using System.Collections.Generic;
using static ConsoleHelper_50.Helper_50;

namespace Modul9.FinalTask2
{
    public delegate void Sort(List<Student> list);

    internal class Program
    {
        public static List<Student> studentList = new()
        {
            new Student { surname = "Орлова" },
            new Student { surname = "Белов" },
            new Student { surname = "Степаненко" },
            new Student { surname = "Барахвин" },
            new Student { surname = "Ремизова" }
        };

        public static event Sort SortAsc;
        public static event Sort SortDesc;

        static void Main(string[] args)
        {
            WriteLn("Hello World!");
            WriteLn("Исходный список фамилий:");
            Student.PrintArray(studentList);

            bool flag = false;
            while (flag == false)
            {
                WriteLn("Введите (1) для сортировки А-Я и (2) для сортировки по Я-А. (0) для выхода из программы", true);
                byte.TryParse(ReadLn(), out byte act);
                try
                {
                    switch (act)
                    {
                        case 1: 
                            SortAsc?.Invoke(studentList);
                            WriteLn("Новый порядок массива");
                            Student.PrintArray(studentList);
                            break;
                        case 2:
                            SortDesc?.Invoke(studentList);
                            WriteLn("Новый порядок массива");
                            Student.PrintArray(studentList);
                            break;
                        case 0:
                            flag = true;
                            break;
                        default:
                            throw new ArgumentException("Введенная команда некорректна");
                    }
                }
                catch (Exception e)
                {
                    WriteLn(e.Message, ConsoleColor.Red);
                }
            }
            WriteLn("Нажмите Enter, чтобы закрыть это окно");
            Console.ReadLine();
        }
    }
}
