using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            for (int k = 1; k <= 100; k++)
            {
                if (k % 3 == 0 || k % 5 == 0){
                    if (k % 3 == 0 && k % 5 == 0){
                    }
                    else {
                        Console.WriteLine(k);
                    }
                }
            }

            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + " - " + j);
                }
                
                else if (j % 3 == 0 && j % 5 != 0)
                {
                    Console.WriteLine("Fizz" + " - " + j);
                }
                else if (j % 3 != 0 && j % 5 == 0)
                {
                    Console.WriteLine("Buzz" + " - " + j);
                }
                
            } 
        }
    
    }
}
