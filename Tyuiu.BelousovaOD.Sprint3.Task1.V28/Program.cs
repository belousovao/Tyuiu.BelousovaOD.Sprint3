using Tyuiu.BelousovaOD.Sprint3.Task1.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла while                                                                                 *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #28                                                                                                *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТб-24-1                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по формуле,при а=0,5                 *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double value = 0.5;

            int startValue = 1;

            int stopValue = 18;

            Console.WriteLine("a:" + value);
            Console.WriteLine("Начальное значение :" + startValue);
            Console.WriteLine("Конечное значение :" + stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда =" + res);

            Console.ReadKey();
        }
    }
}
