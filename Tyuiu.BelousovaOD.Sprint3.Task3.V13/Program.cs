﻿using Tyuiu.BelousovaOD.Sprint3.Task3.V13.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
            Console.WriteLine("* цифру затем преобразовать в число в строке: ?sd!! 5gh. s!               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "?sd!! 5gh. s!";
            Console.WriteLine("Исходня строка = " + value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Получившиеся значение = " + ds.ConvertStringToInt(value));
            Console.ReadKey();
        }
    }
}
