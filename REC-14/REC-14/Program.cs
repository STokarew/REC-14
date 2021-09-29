using System;

namespace REC_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер числа фибоначчи");
            int number = Convert.ToInt32(Console.ReadLine());
            {
                double a = 1;
                double b = 1;
                double c = 0;

                int j = 2;
                while (j <= number)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    j++;
                }
                Console.WriteLine("Под номером " + number + " в ряде Фибоначчи стоит число " + a);
                Console.Read();
            }
        }
    }
}
