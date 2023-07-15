using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Divisible_Two
    {
        public void Number()
        {
            Random random = new Random();
            int num = random.Next(100);
            Console.WriteLine(num);
            //Console.WriteLine("Enter a value");
            //int num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0) 
            {
                Console.WriteLine("The given Number is Divisible by 2");
            }
            else
            {
                Console.WriteLine("The given number not a divisible of 2");
            }
        }
    }
}
