using System;

namespace REC_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер числа фибоначчи");
            int n = Convert.ToInt32(Console.ReadLine());
            {
                double a = 1;
                double b = 1;
                double c = 0;

                int j = 2;
                while (j <= n)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    j++;
                }
                Console.WriteLine("Под номером " + n + " в ряде Фибоначчи стоит число " + a);
                Console.Read();
            }
        }
    }
}
