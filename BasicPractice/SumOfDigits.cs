using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class SumOfDigits
    {
        public void Number()
        {
            int val = 0,add=0;
            Random random = new Random();
            int num = random.Next(100);
            Console.WriteLine(num);
            //Console.WriteLine("Enter a Number");
            //int num=Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                val = num % 10;
                add = val + add;
                num = num / 10;
            }
            Console.WriteLine("Sum of the given number is "+add);
        }
    }
}
