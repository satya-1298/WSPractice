using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter your choose");
                Console.WriteLine("1-Even-Odd");
                Console.WriteLine("2-Positive Negative");
                Console.WriteLine("3-Swaping");
                Console.WriteLine("4-Largest of Two");
                Console.WriteLine("5-Divisible by 25");
                Console.WriteLine("6-Multiple of 3 & 5");
                Console.WriteLine("7-Sum ofThe Given Number");
                Console.WriteLine("8-Reverse a number");
                Console.WriteLine("9-Arithematic Operation on the on single number with digits");
                Console.WriteLine("10-Multiplication Table");
                Console.WriteLine("Alphabets");
                Console.WriteLine("-------------------------------");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        EvenOrOdd evenOrOdd = new EvenOrOdd();
                        evenOrOdd.Number();
                        Console.WriteLine("-------------------------------");
                        break;
                    case 2:
                        Positive_Negative negative = new Positive_Negative();
                        negative.Number();
                        Console.WriteLine("-------------------------------");
                        break;
                    case 3:
                        Swaping swaping = new Swaping();
                        swaping.Number();
                        Console.WriteLine("--------------------------------");
                        break;
                    case 4:
                        Largest_Two largest_Two = new Largest_Two();    
                        largest_Two.Number();
                        Console.WriteLine("--------------------------");
                        break;
                    case 5:
                        Divisible_Two divisible_Two = new Divisible_Two();
                        divisible_Two.Number();
                        Console.WriteLine("------------------------");
                        break;
                    case 6:
                        Multiple_Three_Five multiple_Three_Five = new Multiple_Three_Five();
                        multiple_Three_Five.Number();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 7:
                        SumOfDigits sumOfDigits = new SumOfDigits();
                        sumOfDigits.Number();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 8:
                        ReverseNumber reverseNumber = new ReverseNumber();  
                        reverseNumber.Number();
                        Console.WriteLine("----------------------------");
                        break;
                    case 9:
                        ArithmeticOnaNumber arithmeticOnaNumber = new ArithmeticOnaNumber();
                        arithmeticOnaNumber.Number();
                        Console.WriteLine("--------------------------");
                        break;
                    case 10:
                        MultiplicationTable multiplicationTable = new MultiplicationTable();    
                        multiplicationTable.Number();
                        Console.WriteLine("-----------------------------");
                        break;
                    case 11:
                        AlphabetSize alphabetSize = new AlphabetSize();
                        alphabetSize.Number();
                        break;
                }
            }
        }
    }
}
