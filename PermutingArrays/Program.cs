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
     * Complete the 'twoArrays' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     *  3. INTEGER_ARRAY B
     */

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort((x, y) => y.CompareTo(x));

        foreach (var item in A)
        {for (int i = 0; i < B.Count; i++)
        {
            if(item+B[i]>=k)B.Remove(B[i]); break;  }}
        
        string result= (B.Count>0) ? "NO" : "YES";

            return result;
        }  }

class Solution
{
    public static void Main(string[] args)
    {
        

            int n = 4;

            int k = 5;

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            string result = Result.twoArrays(k, A, B);

            Console.WriteLine(result);
        }


    }

