using System;

namespace DoWhileDemo
{
    class EvenOdd
    {
        internal void EvenOddAdder(int num)
        {
            int i, etotal = 0, ototal = 0;
            char c;
            do
            {
                Console.WriteLine("\tEven\tOdd");
                for (i = 0; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        etotal += i;
                        Console.Write("\t" + i + "\t");
                    }
                    else
                    {
                        ototal += i;
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("\n-------------------------");
                Console.Write("Sum:" + "\t" + etotal + "\t");
                Console.WriteLine(ototal);
                Console.Write("Press Y or y to continue else press other key: ");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y' || c == 'Y');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            new EvenOdd().EvenOddAdder(n);
        }
    }
}