using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalQuestionWithAnswer
{
    public class PalindromeString
    {
        public PalindromeString()
        {
            String str;
            int a, b, flag = 1;
            Console.WriteLine("Enter Any String : ");
            str = Console.ReadLine();

            for (a = 0, b = str.Length - 1; b != 0; a++, b--)
            {
                if (str[a] == str[b])
                {

                }
                else
                {
                    flag = 0;
                    break;
                }

            }
            if(flag==1)
                Console.WriteLine("String is Palindrom");
            else
                Console.WriteLine("String is not Palindrom");
            Console.ReadLine();
        }
        //this is 2nd meyhods
        public PalindromeString(string s)
        {
            String str="";
            int a;
            Console.WriteLine(" String is  : "+s);         
            for (a = s.Length-1;a>=0;  a--)
            {
                str = str + s[a];
            }
            if (str == s)
                Console.WriteLine("String is Palindrom");
            else
                Console.WriteLine("String is not Palindrom");
            Console.ReadLine();
        }
    }
}
