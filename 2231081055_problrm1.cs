using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter the first number : ");
           int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a+b;
            Console.WriteLine("{0} + {1} = {2}",a,b,sum);

            int sub = a-b;
            Console.WriteLine("{0} - {1} = {2}",a,b,sub);

            int multi = a*b;
            Console.WriteLine("{0} x {1} = {2}",a,b,multi);

            double div = a/b;
            Console.WriteLine("{0} x {1} = {2:#.##}",a,b,div);

        }
    }
}
