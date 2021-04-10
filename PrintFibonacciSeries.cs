using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class PrintFibonacciSeries
    {
        int n1=0, n2=1,n3;
        public PrintFibonacciSeries()
        {
           
            Console.Write("Enter any Numbers:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numbers : " + n1);
            Console.WriteLine("numbers : " + n2);

            for (n3 = 2; n3 <= n; n3++)
            {
                //n2 = n1;
                int num=n1+n2;
                Console.WriteLine("numbers : "+num);
                n1 = n2;
                n2 = num;
            }
            Console.ReadLine();
        }
        public bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }
        public void  PrintFibonacciSerie(int n)
        {
             //isPerfectSquare(5 * n * n + 4) || isPerfectSquare(5 * n * n - 4);
             if(isPerfectSquare(5 * n * n + 4)==true || isPerfectSquare(5 * n * n - 4)==true)
            //if (isPerfectSquare == true)
                Console.WriteLine(n+" :is Fibonacci number");
            else
                Console.WriteLine(n+" :is not Fibonacci number");
            Console.ReadLine();
        }
    }
}
