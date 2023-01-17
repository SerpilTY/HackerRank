using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();
            string res="";

            for (int i = 0; i < input.Length; i++)
                {
                   res= (input[i] == input2[i]) ? res+="0" : res="1";              
                }
            
            Console.WriteLine(res);
        }
    }
}