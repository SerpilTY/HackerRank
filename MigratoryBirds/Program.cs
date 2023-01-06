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

    public static int migratoryBirds(List<int> arr)
    {
        double one = 0.1; double two = 0.2; double three = 0.3;
        double four = 0.4; double five = 0.5;
        int result = 0;

        foreach (var item in arr)
        {
            if (item.Equals(1)) { one++; }
            else if (item.Equals(2)) { two++; }
            else if (item.Equals(3)) { three++; }
            else if (item.Equals(4)) { four++; }
            else if (item.Equals(5)) { five++; }
        }

        List<double> myArr = new List<double> {one, two, three, four, five};
        myArr.Sort();

        double biggest = myArr[4];
        for (int i = 0; i < myArr.Count; i++)
        {
            if (Convert.ToInt32(myArr[i]) == Convert.ToInt32(biggest))
            {
                result = Convert.ToInt32((myArr[i] - Math.Truncate(myArr[i])) * 10);
                break;
            }
            else
            {
                result = Convert.ToInt32(myArr[4] - Math.Truncate(myArr[4]));
            }
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {


        List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

        int result = Result.migratoryBirds(arr);

        System.Console.WriteLine(result);
    }
}
