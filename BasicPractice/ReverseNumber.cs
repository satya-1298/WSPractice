using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class ReverseNumber
    {
        public void Number()
        {
            int val = 0, rev = 0;
            //Random random = new Random();
            //int num = random.Next(1000);
            //Console.WriteLine(num);
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                val = num % 10;
                rev = rev * 10+val;
                num = num / 10;
            }
            Console.WriteLine("Sum of the given number is " + rev);
            if(rev==temp)
            {
                Console.WriteLine("It is a Reverse Palindrom");
            }
            else
            {
                Console.WriteLine("Not a Reverse Palindrom");
            }
        }
    }
}
