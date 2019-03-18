//вариант 12
using System;


namespace Complex_numbers
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double module2;
            Console.WriteLine("Введите Module1= ");
            double module = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Argument1= ");
            int argument = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите Module2= ");
                module2 = Convert.ToDouble(Console.ReadLine());
                if (module2 == 0)
                    Console.WriteLine("На ноль делить нельзя, введите заново");
            }
            while (module2 == 0);
            Console.WriteLine("Введите Argument2= ");
            int argument2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Complex x = new Complex(module, argument);
            Complex y = new Complex(module2, argument2);
            Complex um = x * y;
            Complex del = x / y;
            Complex pl = x + y;
            Complex min = x - y;
            Complex k = new Complex(module, argument);

            Console.WriteLine("x=" + x.Module + "(Cos(" + x.Argument + ")+iSin(" + x.Argument + ")");
            Console.WriteLine("y=" + y.Module + "(Cos(" + y.Argument + ")+iSin(" + y.Argument + ")");
            Console.WriteLine("Умножение " + "\n" + um.ToString());
            Console.WriteLine("Деление " + "\n" + del.ToString());
            Console.WriteLine("Сложение " + "\n" + pl.ToString());
            Console.WriteLine("Вычитание " + "\n" + min.ToString());

            Console.ReadLine();
        }
    }
}
