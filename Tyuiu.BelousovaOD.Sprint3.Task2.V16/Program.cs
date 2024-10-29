using Tyuiu.BelousovaOD.Sprint3.Task2.V16.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double value = 2;
            int startValue = 1;
            int stopValue = 5;
            Console.Title = "Спринт #3 | Выполнилa: Белоусова О.Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет           *");
            Console.WriteLine("* произведение ряда по формуле                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение n: {value}");
            Console.WriteLine($"Начало цикла: {startValue}");
            Console.WriteLine($"Конец цикла: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение ряда: {ds.GetMultiplySeries((int)value, startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
