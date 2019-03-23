using System;

namespace Fibonacci
{
    class Program
    {
       
        static long Fibonacci(int n)
        {
            if (n < 3)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            int InputNumber = 0;
            for (; ; )
            {
                Console.WriteLine("\n1--First Task.\n2--Second Task.");
                string InputFirst = Console.ReadLine();
                if (Int32.TryParse(InputFirst, out InputNumber) && ((InputNumber == 1) || (InputNumber == 2)))
                {
                    switch (InputNumber)
                    {
                        case 1:
                            int num = 0;//2 завдання
                            Console.WriteLine("Input number:");//кількість виведених чисел Фібоначчі
                            string InputSecond = Console.ReadLine();
                            if (Int32.TryParse(InputSecond, out num) && (num != 0)&&(num>0))
                            {
                                for (int i = 1; i <= num; i++)
                                {
                                    Console.Write("{0}, ", Fibonacci(i));
                                }

                                Console.WriteLine("...");

                            }
                            else
                                Console.Write("Incorrect input!!!!");
                            break;
                        case 2:
                            Console.WriteLine("Input number:");//до введеного числа
                            string InputThird = Console.ReadLine();
                            if (Int32.TryParse(InputThird, out num) && (num != 0) && (num > 0))
                            {
                                for (int i = 1; i < num; i++)
                                {
                                    if (Fibonacci(i) < num)
                                    {
                                        Console.Write("{0}; ", Fibonacci(i));
                                    }

                                }
                            }
                            else
                                Console.Write("Incorrect input!!!!");
                            break;

                    }

                }
                else
                    Console.Write("Incorrect input!!!!");
            }

        }
           


    }
}