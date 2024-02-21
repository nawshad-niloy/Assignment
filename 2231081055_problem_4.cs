using System;
namespace problem 
{

    class Hello 
    {

        static void Main(string[] args)
        {
            int[] numbers = {45, 89, 80, 15, 23, 24, 66, 49, 38, 77};
            int sum = 0;
            int min = numbers[0];
            for(int i = 0; i < numbers.Length;i++)
            {
                sum += numbers[i];
                if(numbers[i]<min)
                {
                    min = numbers[i];
                }
            }

            double avgr = sum/(double)numbers.Length;

            Console.WriteLine($"The Average of the numbers of Array : {avgr}");
            Console.WriteLine($"The minimum number from the array : {min}");
        }
    }
}

