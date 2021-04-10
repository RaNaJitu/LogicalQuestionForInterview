using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class SwapingWithTamp
    {
        public SwapingWithTamp()
        {
            //Swaping two Numbers With using tamp/3rd Variables
            int p, q;
            Console.Write("Enter the values of p= ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the values of q= ");
            q = Convert.ToInt32(Console.ReadLine());
            int temp = p;
            p = q;
            q = temp;
            Console.WriteLine("\nAfter Swapping a= " + p + "  b= " + q);

            Console.ReadLine();
        }
    }
}
