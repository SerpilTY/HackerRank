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
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        int[] freaquency=new int[queries.Count];
 
        for (int i = 0; i < queries.Count; i++)
        {
            for (int j = 0; j < strings.Count; j++)
            {
                if(queries[i]==strings[j])freaquency[i]++;
            }
        }
        return freaquency.ToList();
    }}

class Solution
{
    public static void Main(string[] args)
    {
        
        List<string> strings = new List<string>(){"aba","babacığım","canımbabam","canımıniçibabcığım","babi","baba","babam","aba","xzxb"};

        List<string> queries = new List<string>(){"canımbabam","babi","aba","babacığım","xzxb","ab","babacığım"};
       
        List<int> res = Result.matchingStrings(strings, queries);

        Console.WriteLine(String.Join("\n", res));

    }
}