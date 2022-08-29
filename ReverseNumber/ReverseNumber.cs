using System;
namespace ReverseNumber
{
    public class ReverseNumber
    {
        int reverseNum=0;
        public void NumberCheck()
        {
            Console.WriteLine("Enter Number");
            int num =Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                int reminder = num % 10;
                reverseNum = reverseNum * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine(reverseNum);
        }
    }
}
