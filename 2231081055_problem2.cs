using System;
namespace problem 
{

    class Hello 
    {

        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 5;i<=500;i=i+5)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
