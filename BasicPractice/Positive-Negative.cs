using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Positive_Negative
    {
        public void Number()
        {
            Random random = new Random();
            int num=random.Next(-100,100);  
            Console.WriteLine(num);
            //Console.WriteLine("Enter a number");
            //int num=Convert.ToInt32(Console.ReadLine());
            if(num==0)
            {
                Console.WriteLine("The given number is Zero");
            }
            else if (num>0)
            {
                Console.WriteLine("The given Number is Positive");
            }
            else 
            {
                Console.WriteLine("The Number is negative");
            }
        }
    }
}
