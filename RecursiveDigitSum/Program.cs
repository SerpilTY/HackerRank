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
        long sum = 0;
        List<long> numbers = new List<long>();

        numbers = n.Select(digit => long.Parse(digit.ToString())).ToList();

        if (numbers.Count == 1) sum = numbers[0];

        else
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            sum = sum * k;
            while (numbers.Count >= 1)
            {
                numbers.Clear();
                numbers = sum.ToString().Select(digit => long.Parse(digit.ToString())).ToList();
                sum = 0;
                for (var l = 0; l < numbers.Count; l++)
                {
                    sum += numbers[l]; }

                if (sum.ToString().Length == 1) break;
            } }
        return Convert.ToInt32(sum);
    } }
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
