using System;
namespace perfectNumber
{
    public class perfectNumber
    {
        int numCheck = 0;
        public void perfectNumCheck()
        {
            Console.WriteLine("Enter the number to check either its perfectNum or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <=num/2; i++)
            {
                if (num%i == 0)
                {
                    numCheck += i;
                }
            }
            if (numCheck == num)
            {
                Console.WriteLine("perfectNum");
            }
        }

    }
}
