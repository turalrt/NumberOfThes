using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15 /*tapsiriq 5*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The string where the word the present more than once";
            string word = "The";
            string word1 = "the";
            string[] newstr = str.Split(' '); /*stringi sozlere ayiririq*/
            int count = 0;
            for (int i = 0; i < newstr.Length; i++)
            {
                if (word.Equals(newstr[i]) || word1.Equals(newstr[i]))
                    count++;
            }
            Console.WriteLine("The frequency of the word 'the' is : {0}", count);
        }
    }    
}
