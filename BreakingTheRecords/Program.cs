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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> breakinghighNum=new List<int>();
        List<int> breakingsmallNum=new List<int>();
        int biggest=0;  int smallest=0;
        breakinghighNum.Add(scores[0]);
        breakingsmallNum.Add(scores[0]);
        /* breakinghighNum.Add(max);
        breakingsmallNum.Add(min); */

       
        for (int i = 0; i < scores.Count-1; i++)
        {
            
            if(scores[i]<scores[i+1] && scores[i+1]> breakinghighNum.Max() ){
            biggest=scores[i+1];
            breakinghighNum.Add(biggest);
            System.Console.WriteLine("biggest= "+biggest);
            }
          
        }

        for (int i = 0; i < scores.Count-1; i++)
        {
             
            if(scores[i+1]<scores[i] && scores[i+1]<breakingsmallNum.Min())
            {smallest=scores[i+1];
            breakingsmallNum.Add(smallest);
            System.Console.WriteLine("smallest= "+smallest);}
        }

List<int> result=new List<int>();
        result.Add(breakinghighNum.Count-1); 
        result.Add(breakingsmallNum.Count-1);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

foreach (var item in result)
{
    System.Console.WriteLine(item);
}
    }
}
