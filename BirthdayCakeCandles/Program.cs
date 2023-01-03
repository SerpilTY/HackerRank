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
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        candles.Sort();
        int index=0;
        foreach (var item in candles)
        {
            if(item==candles[candles.Count-1] )
            index=(candles.IndexOf(item));  
        }
return ((candles.Count)-index);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        

        List<int> candles = new List<int>{3,2,1,3};
        

        int result = Result.birthdayCakeCandles(candles);

        System.Console.WriteLine(result);
    }
}
