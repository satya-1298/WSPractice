using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Swaping
    {
        public void Number()
        {
            Random random = new Random();
            int num = random.Next(100);
            Console.WriteLine(num);
            int num2=random.Next(100);  
            Console.WriteLine(num2);
            //Console.WriteLine("Enter a value");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second value");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swaping num = " + num + " num2 =  " + num2);
            int val = num + num2;
            num = val - num;
            num2= val - num2;

            Console.WriteLine("After Swaping num = " + num + " num2 =  " + num2);
        }
    }
}
