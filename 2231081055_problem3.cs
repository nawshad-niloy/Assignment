using System;
using System.Transactions;
namespace problem 
{

    class Hello 
    {

        static void Main(string[] args)
        {
           Console.Write("Enter the first number of the series : ");
           int n = Convert.ToInt32(Console.ReadLine());
           for(int i = n;i >= 0; i--)
           {
                Console.Write(i + " ");
           }
        }
    }
}

