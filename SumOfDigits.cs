using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class SumOfDigits
    {
        //Sum  the digits of a given number 
        int n,k,sum;
        public SumOfDigits()
        {
            Console.Write("Enter any Numbers: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                sum = sum + k;
            }
            Console.WriteLine("Sum  the digits of a given number ="+sum);
            Console.ReadKey();
        }
    }
}
