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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here

        int swap = 0;
        int temp = 0;
   for (int i=0;i<a.Count();i++)
   {   
       for (int j = 0; j < a.Count() - (i + 1); j++)
       {
           if (a[j] > a[(j + 1)])
           {
              temp = a[j];
              a[j] = a[j + 1];
              a[j + 1] = temp;
              swap++;
           }

       }
   }
        System.Console.WriteLine("Array is sorted in "+swap+" swaps.");
        System.Console.WriteLine("First Element: " + a[0]);
        System.Console.WriteLine("Last Element: " + a[a.Count - 1]);

    }
}