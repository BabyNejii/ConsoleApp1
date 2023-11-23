using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добре дошли в този калкулатор за лице на правоъгълник и изчисляване на дискриминанта на уравнение с дадени стойности a,b,c");
            Console.WriteLine("Въведете стойност А(дължина) на правоъгълника в сантиметри");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Въведете стойност Б(височина) на правоъгълника сантиметри");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0){
                int s = a * b;
                Console.WriteLine("Лицето на правоъгълника е " + s + " cm2");
            }
            else
            {
                Console.WriteLine("Невалидни стойности");
            }
            Console.WriteLine("Сега ще изчислим дискриминантата");
            Console.WriteLine("Въведете стойност на А");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Въведете стойност на Б");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Въведете стойност на С");
            int c = Convert.ToInt32(Console.ReadLine());
            if(z>=1 && x>=1 && c >= 1)
            {
                int d = x * x - 4 * z * c;
                if(d>=0){
                    Console.WriteLine("Дискриминантата е " + d);
                }
                else
                {
                    Console.WriteLine("Дискриминантата е по-малка от 0, няма решение");
                }
            }
            else {
                Console.WriteLine("Невалидна/и стойности");
                    }
        }
    }
}
