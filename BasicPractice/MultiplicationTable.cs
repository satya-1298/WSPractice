using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class MultiplicationTable
    {
        public void Number()
        {
            int val = 0;
            Console.WriteLine("Enter a number for table");
            int no=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Range");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table is \n");
            for (int i = 1; i <= num; i++) 
            {
                val = i * no;
                Console.WriteLine( no+" * "+i+" = "+val);
                
            }
        }
    }
}
