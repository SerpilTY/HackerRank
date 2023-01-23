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
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        // Write your code here

        int size = s.Count();

        int sum = 0;

        int output = 0;

        for (int i = 0; i < m; i++) // Get the initial sum
        {
            sum += s[i];
        }

        if (sum == d) // Check whether the sum match the d value.
        {
            output++;
        }

        for (int i = 0; i < size - m; i++) // Shift by deleting the head element and
        {                                 // adding the element after the tail. 
            sum -= s[i];
            sum += s[i + m];

            if (sum == d)
            {
                output++;
            }
        }

        return output;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> s = new List<int> { 1, 2, 1, 3, 2 };
        int d = 3;

        int m = 2;

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);

    }
}
