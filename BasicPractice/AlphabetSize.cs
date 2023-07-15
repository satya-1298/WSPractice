using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class AlphabetSize
    {
        public void Number()
        {
            int i;
            char c='a';
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();
            string lower=str.ToLower();
            Console.WriteLine("String in Lower Case  "+lower);
            string upper=str.ToUpper(); 
            Console.WriteLine("String in Upper Case  "+upper);
            i = (int)c;
            Console.WriteLine(i);
            foreach(char ch in str)
            {
                Console.WriteLine((int)ch);
            }

        }
    }
}
