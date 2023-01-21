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
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
       // var x = new System.Text.StringBuilder().Insert(0, n, k).ToString();

        int sum = 0;
        List<int> numbers = new List<int>();
        List<char> numberss = n.ToCharArray().ToList();

        if (numberss.Count == 1) sum = numberss[0] - '0';

        else
        {
            for (var i = 0; i < numberss.Count; i++)
            {
                numbers.Add(Convert.ToInt32((numberss[i]) - '0'));
                sum += numbers[i];
            }
            sum=sum*k;

            while (numbers.Count >= 1){

                numberss.Clear();
                numbers.Clear();

                for (var j = 0; j < sum.ToString().Length; j++)
                {
                    numberss.Add((sum.ToString())[j]);
                }
                sum = 0;
                for (var l = 0; l < numberss.Count; l++)
                {
                    numbers.Add((numberss[l]) - '0');
                    sum += numbers[l];
                }

                if (sum.ToString().Length == 1) break;
            }
        }
        return sum;
    }
}


class Solution
{
    public static void Main(string[] args)
    {

        string n = "148";

        int k = 3;

        int result = Result.superDigit(n, k);

        Console.WriteLine(result);
    }
}
