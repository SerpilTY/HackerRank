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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<double> result=new List<double>();
        double positive=0.0; result.Add(positive);
        double negative=0.0; result.Add(negative);
        double zero=0.0; result.Add(zero);
        
foreach (var item in arr)
{
    if(item>0){positive++;}
    if(item<0){negative++;}
    if(item==0){zero++;}
    
}
    positive=positive/Convert.ToDouble(arr.Count);
    negative=negative/Convert.ToDouble(arr.Count);
    zero=zero/Convert.ToDouble(arr.Count);
    System.Console.WriteLine(positive.ToString("F6"));
    System.Console.WriteLine(negative.ToString("F6"));
    System.Console.WriteLine(zero.ToString("F6"));
    
      
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
