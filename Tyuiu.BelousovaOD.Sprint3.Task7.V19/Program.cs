using Tyuiu.BelousovaOD.Sprint3.Task7.V19.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (5*x+2.5)/(sin(x)-2)+2                                           *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапозоне [-5,5].Произвести   *");
            Console.WriteLine("* проверку деления на ноль.При делении на ноль вернуть значение 0.        *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            int start = -5, end = 5;
            Console.WriteLine("Начало шага = " + start);
            Console.WriteLine("Конец шага = " + end);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int len = ds.GetMassFunction(start, end).Length;
            double[] mass = new double[len];
            mass = ds.GetMassFunction(start, end);
            Console.WriteLine("+------+-----------+");
            Console.WriteLine("|  x   |   f(x)    |");
            Console.WriteLine("+------+-----------+");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("| {0,2:d}   |   {1,5:f2}   |", i - 5, mass[i]);
            }
            Console.WriteLine("+------+-----------+");
            Console.ReadKey();
        }
    }
}
