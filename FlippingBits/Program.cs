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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string binary = Convert.ToString(n, 2);
        List<char> binaryChar = new List<char>();
        for (int i = 0; i < 32 - binary.Length; i++)
        {
            binaryChar.Add('0');
        }

        foreach (var item in binary)
        {
            binaryChar.Add(item);
        }

        for (int i = 0; i < binaryChar.Count; i++)
        {
            if (binaryChar[i] == '0') binaryChar[i] = '1';
            else if (binaryChar[i] == '1') binaryChar[i] = '0';
        }

        String flippedbinary = new String(binaryChar.ToArray());
        long a = Convert.ToInt64(flippedbinary, 2);
        return a;
    }
}

class Solution
{
    public static void Main(string[] args)
    {


        long n = 752418;

        long result = Result.flippingBits(n);

        System.Console.WriteLine(result);
    }
}