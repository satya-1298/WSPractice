using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Multiple_Three_Five
    {
        public void Number()
        {
            int val = 0;
            Console.WriteLine("Enter a value");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                if(i%3==0||i%5==0)
                {

                    Console.Write(" "+i);
                    val = val + i;
                    
                }
            }
            Console.WriteLine("\n The sum of 3 and 5 Multiples are " + val);
        }
    }
}
