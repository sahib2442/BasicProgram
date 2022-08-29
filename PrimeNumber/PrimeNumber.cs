using System;
namespace PrimeNumber
{
    public class PrimeNumber
    {
        public void PrimeCheck()
        {
            Console.WriteLine("Enter the number to check either its prime num or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num%i == 0)
                {
                    Count++;
                }
            }
            if (Count == 2)
            {
                Console.WriteLine("its a prime number");
            }
        }
    }
}
