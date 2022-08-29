using System;
namespace fibinocciseries
{
    public class fibinocciseries
    {
        int firstNum = 0, secondNum = 0, thirdNum = 0;
        public void print()
        {
            Console.WriteLine("Enter the number to print fibinocciseries");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                num--;
            }
            Console.WriteLine((firstNum +"\n"+ secondNum +"\n"+ thirdNum));
        }
    }
}
