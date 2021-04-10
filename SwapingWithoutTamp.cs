using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class SwapingWithoutTamp
    {
        public  SwapingWithoutTamp()
        {
            //Swaping two Numbers Without using 3rd Variables
            int a, b;
            Console.Write("Enter the values of a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the values of b= ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a-b;
            a = a-b;
            Console.WriteLine("\nAfter Swapping a= " + a + "  b= " + b);

            Console.ReadLine();
        }

    }
}
