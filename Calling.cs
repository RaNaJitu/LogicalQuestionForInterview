using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class Calling
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***Swaping two Numbers With using tamp/3rd Variables***");
            //SwapingWithTamp s = new SwapingWithTamp();

            //Console.WriteLine("***Swaping two Numbers Without using tamp/3rd Variables***");
            //SwapingWithoutTamp s1 = new SwapingWithoutTamp();

            //Console.WriteLine("***Sum  the digits of a given number ***");
            //SumOfDigits s3 = new SumOfDigits();

            //Console.WriteLine("***Palindrome ***");
            //PalindromeString p = new PalindromeString();

            //Console.WriteLine("***Palindrome method2 ***");
            //PalindromeString p1 = new PalindromeString("MAM");

            //Console.WriteLine("***Print Fibonacci Series ***");
            //PrintFibonacciSeries pp = new PrintFibonacciSeries();
            //Console.WriteLine("***Check Given Numbers Fibonacci Series ***");
            ////PrintFibonacciSerie pb = new PrintFibonacciSerie();
            //pp.PrintFibonacciSerie(55);

            Console.WriteLine("**Check Prime Numbers **");
            PrimeNumber pn = new PrimeNumber();
            pn.PrintPrimeNumber(100);



        }
    }
}
