using System;

namespace FindNumbersAboveBelowAvg
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("How many numbers do you want to register?");
            uint counter;
            counter = Convert.ToUInt32(Console.ReadLine());
            uint[] numbers = new uint[counter];
            uint sum = 0, avg = 0, low = 0, high = 0;
            for (int i = 0; i < counter; i++)
            {
                Console.Write("Number {0}: ", (i + 1));
                numbers[i] = Convert.ToUInt32(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / counter;
            //avg = sum / numbers.Length;
            for (int i = 0; i < counter; i++)
            {
                if (numbers[i] < avg)
                {
                    low++;
                }
                else
                {
                    high++;
                }
            }

            Console.WriteLine("The average is : {0}", avg);
            Console.WriteLine("The numbers above the average are: {0}", high);
            Console.WriteLine("The numbers below the average are: {0}", low);
            Console.ReadKey();
        }
    }
}