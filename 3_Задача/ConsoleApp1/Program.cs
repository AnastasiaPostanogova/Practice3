using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            bool ok;
            do
            {
                Console.WriteLine("Введите число Х");
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (!ok)
                    Console.WriteLine("Ошибка");
            }
            while (!ok);
            if (x <= 0) y = -x;
                else if ((x > 0) && (x < 1)) y = x;
                    else if ((x >= 1) && (x <= 2)) y = 1;
                        else y=-2*x + 5;
            Console.WriteLine("Решением примера является число: {0}", y);
        }
    }
}