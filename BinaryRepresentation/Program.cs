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
List<int> binary=new List<int>();

for (int i = n; i >1; i=i/2)
{
    binary.Add(i%2);
    if(i==2)binary.Add(1);
    if(i==3) binary.Add(1);
    System.Console.WriteLine( "i= "+i);
}
binary.Reverse();
foreach (var item in binary)
        {
            System.Console.Write($"{item}");
           
        }; 
         System.Console.WriteLine("");
binary.ToString();
         foreach (var item in binary)
        {
            System.Console.Write($"{item}");
           
        }; 
 System.Console.WriteLine("");
       

        

     /* 
        if(temp>count)System.Console.WriteLine(temp);
        else System.Console.WriteLine(count); */

        List<char> ones=new List<char>();
string bino=binary.ToString();
List<int> count=new List<int>();
        for (var i = 0; i < bino.Count(); i++)
        {
            if(bino[i]==bino[i+1] && bino[i]==1){
                ones.Add(bino[i]);
                ones.Add(bino[i+1]);
                if(bino[i]==0)
                count.Add(ones.Count);
                ones.Clear();
            }
        }
        count.Sort();
        System.Console.WriteLine(count[count.Count-1]);
    }
}
