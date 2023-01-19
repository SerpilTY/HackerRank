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
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        List<double> b = a.ConvertAll(x => (double)x);
        b.Sort();
        int myInt = 0;
        for (int i = 0; i < b.Count - 1; i++)
        {
            for (int k = i + 1; k < b.Count; k++)
            {
                if (b[i] == b[k])
                {    b[i] += 0.1;
                     b[k] += 0.1;
                } }

            for (int j = 0; j < b.Count; j++)
            {
                if (b[j] - Math.Floor(b[j]) == 0)
                    myInt = Convert.ToInt32(b[j]);
            } }
        if (a.Count == 1) myInt = a[0];
        return myInt;
    } }

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int>() { 1, 0, 3, 2, 4, 3, 2, 1, 4 };

        int result = Result.lonelyinteger(a);
        System.Console.WriteLine(result);
    }
}
