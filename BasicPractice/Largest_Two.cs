using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Largest_Two
    {
        public void Number()
        {
            //Random random = new Random();
            //int num = random.Next(100);
            //Console.WriteLine(num);
            //int num2 = random.Next(100);
            //Console.WriteLine(num2);
            Console.WriteLine("Enter a value");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second value");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num.CompareTo(num2) < 0 )
            {
                Console.WriteLine("Second Value is Largest");
            }
            else if(num.CompareTo(num2) > 0 )
            {
                Console.WriteLine("First value Largest");
            }
            else 
            {
                Console.WriteLine("Both are equal");
            }
        }
    }
}
