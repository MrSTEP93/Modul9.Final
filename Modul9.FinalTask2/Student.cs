using System;
using static ConsoleHelper_50.Helper_50;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9.FinalTask2
{
    public class Student : IComparable<string>
    {

        public string surname;

        public Student()
        {
            Program.SortAsc += SortAZ;
            Program.SortDesc += SortZA;
        }

        public static void PrintArray(List<Student> list)
        {
            foreach (var man in list)
            {
                WriteLn("\t" + man.surname);
            }
            WriteLn("");
        }

        public int CompareTo(string other)
        {
            return surname.CompareTo(other);
        }

        public static void SortAZ(List<Student> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].surname.CompareTo(list[j].surname) > 0)
                    {
                        Student temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public static void SortZA(List<Student> list)
        {
            SortAZ(list);
            list.Reverse();
        }

    }
}
