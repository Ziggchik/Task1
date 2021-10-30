using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while (again == 'д')
            {
                int a;
                int b;
                int c;
                int d;
                int e;

                Console.WriteLine("Для очистки последнего числа нажмите Backspase");
                Console.WriteLine("Для очистки всей строки нажмите Esc");

                Console.WriteLine("Введите первое число:");
                a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите третье число:");
                c = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите число для факториала:");
                d = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите число для суммы N..1:");
                e = Int32.Parse(Console.ReadLine());

                int factorial = 1;
                for (int i = 1; i <= d; i++)
                {
                    factorial *= i;
                    if (i == d)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} * ", i);
                    }
                }
                Console.WriteLine(" = {0}-факториал числа", factorial);

                int summ = 0;
                for (int i = 1; i <= e; i++)
                {
                    summ += i;
                    if (i == e)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} + ", i);
                    }
                }
                Console.WriteLine(" = {0}-сумма чисел", summ);


                int maximal = Math.Max(Math.Max(a, b), c);
                int minimal = Math.Min(Math.Min(a, b), c);

                Console.WriteLine("{0} (минимальное число) -> {1} -> {2} (максимальное число)",
                    minimal,
                    a + b + c - maximal - minimal,
                    maximal);

                Console.WriteLine("Вы хотите продолжить работу? (д-продожить/н-закончить)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
