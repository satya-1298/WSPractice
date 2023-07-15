using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public  class ArithmeticOnaNumber
    {
        public void Number()
        {
            int val = 0, add = 0;
            int sub=0, mul = 1;
            float div = 1;
            //Random random = new Random();
            //int num = random.Next(100);
            //Console.WriteLine(num);
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                
                val = num % 10;
                add = val + add;
                sub = val - sub; 
                mul = val*mul;
                div = val/div;
                num = num / 10;
            }
            Console.WriteLine("Sum of the given number is " + add);
            Console.WriteLine("Subtration of given number "+sub);
            Console.WriteLine("Multiplication of given number "+mul);
            Console.WriteLine("Division of given number "+div);

        }
    }
}
