using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class PrimeNumber
    {
        public PrimeNumber()
        {
            int count = 0;
            Console.Write("Enter Any Numbers : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n%i==0)
                {
                    count++;
                }
            }
            if(count==2)
                Console.WriteLine(n+" Prime Number");
            else
                Console.WriteLine(n+" Not Prime Number");

            Console.ReadLine();
        }
        public void  PrintPrimeNumber(int num)
        {
            
            for (int number = 1; number <= num; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    Console.Write("\t"+number);
            }
            Console.ReadLine();
        }   
    }
}
