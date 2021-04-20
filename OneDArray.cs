using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    class OneDArray
    {
        public void oneDArray()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length-1; i++)
            {
                Console.WriteLine("Enter the Age : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Age : "+a[i]);
            }
            Console.WriteLine("Age are :");
            for (int i = 0; i < a.Length-1; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
        public void twoDArray()
        {
            int[,] a = new int[2,3];
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    Console.WriteLine("Enter the Age : ");
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            Console.WriteLine("Age are :");
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    Console.WriteLine(a[i, j]);
                }
                
                //a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
