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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        string a = s.ToLower();
        //String.Concat(a.OrderBy(c => c));
        List<char> alphabet = new List<char>();
        char[] lowerCase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        foreach (var item in lowerCase)
        { alphabet.Add(item); }

            for (int i = 0; i < a.Length ; i++)
            {
                if(alphabet.Contains(a[i]))alphabet.Remove(a[i]);
            }
       
        string result= (alphabet.Count > 0) ? "not pangram" : "pangram";
        return result;
    }}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "We promptly judged antique ivory buckles for the next prize";

        string result = Result.pangrams(s);
        System.Console.WriteLine(result);
    }
}