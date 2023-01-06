using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'factorial' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER n as parameter.
     */

    public static int factorial(int n)
    {
        int result=1;
            for (int i = n; i > 1; i--)
            {
                result=n*(factorial(n-1));
                if(n<=1) return 1;
            }
            
            return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        int n = 4;

        int result = Result.factorial(n);
System.Console.WriteLine(result);
        
    }
}