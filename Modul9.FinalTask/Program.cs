using System;
using static ConsoleHelper_50.Helper_50;

namespace Modul9.FinalTask1
{
    internal class Program
    {
        static MyCompanyEx NotEnoughTime = new MyCompanyEx("Недостаточно времени для решения данной задачи!");
        static MyCompanyEx NoSpecification = new MyCompanyEx("В задаче нет конкретики");
        static MyCompanyEx SalaryException = new MyCompanyEx("Мне за это не платят!!");
        static MyCompanyEx CrackedLipException = new MyCompanyEx("Заказчику следует закатать губу");

        static void Main(string[] args)
        {
            WriteLn("Hello World! давай разберемся с заявками от руководства");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SetATask(new Random().Next(0, 6));
                }
                catch (MyCompanyEx e)
                {
                    Write($"Произошла внутренняя ошибка: { e.Data["ExceptionDate"] } ");
                    WriteLn(e.Message, ConsoleColor.Red);
                    if (!string.IsNullOrEmpty(e.HelpLink))
                    {
                        WriteLn("Для решения проблемы обращайтесь сюда: " + e.HelpLink);
                    }
                }
                catch (Exception e)
                {
                    WriteLn(e.Message, ConsoleColor.DarkRed);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
        
        static void SetATask(int number)
        {
            Write("Задача: ");
            switch (number)
            {
                case 1: 
                    WriteLn("Нужно обновить все магазины до завтра", ConsoleColor.White);
                    throw NotEnoughTime;
                    break;
                case 2:
                    WriteLn("Проверить все ТСД на магазинах", ConsoleColor.White);
                    throw NoSpecification;
                    break;
                case 3:
                    WriteLn("Сделать нам новый отчет", ConsoleColor.White);
                    throw SalaryException;
                    break;
                case 4:
                    WriteLn("Сделать доработку как в 1С", ConsoleColor.White);
                    throw CrackedLipException;
                    break;
                case 5:
                    WriteLn("Cделать перестановку на трех магазинах сразу", ConsoleColor.White);
                    throw new MyCompanyEx("Недостаточно сотрудников для решения данной задачи", "http://hh.ru");
                    break;
                default:
                    WriteLn("А вот еще мы хотим....", ConsoleColor.White);
                    throw new NotSupportedException("Задача не поддерживается");
                    break;
            }
        }
    }
}
