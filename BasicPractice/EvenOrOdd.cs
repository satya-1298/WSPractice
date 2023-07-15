using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public  class EvenOrOdd
    {
        public void Number()
        {
            Console.WriteLine("Enter a range");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The EVEN numbers from the given range {0} is -- ",num);
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" "+i);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The ODD numbers from the given range {0} is -- ", num);
            for (int j = 0; j <= num; j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(" "+j);
                }
              
            }
            Console.WriteLine("\n");
        }
    }
    
}
