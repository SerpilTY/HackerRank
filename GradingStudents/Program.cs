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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> gradings = new List<int>();
        for (int i = 0; i < grades.Count; i++)
        {

            if (grades[i] < 38)
            {
                gradings.Add(grades[i]);
            }
            if (grades[i] == 100)
            {
                gradings.Add(grades[i]);
            }
            else if (grades[i] >= 38)
            {
                int x = 5;
                for (int j = 8; j <= 20; j++)
                {
                    if (x * j - grades[i] < 3 && x * j - grades[i] > 0)
                    {
                        grades[i] = x * j;
                        gradings.Add(grades[i]);
                        break;
                    }
                    else if (x * j - grades[i] >= 3)
                    {
                        gradings.Add(grades[i]);
                        break;
                    }
                }

            }
        }
        return gradings;
    }
}

class Solution
{
    public static void Main(string[] args)
    {


        List<int> grades = new List<int>{85,
95,
21,
0,
18,
100,
18,
62,
30,
61,
55,
0,
45,
2,
29,
55,
61,
40,
14,
4,
29,
100,
37,
23,
46,
9,
80,
62,
20,
40,
51,
100,
60,
47,
4,
86,
61,
70,
17,
45,
6,
1,
95,
95};

        var result = Result.gradingStudents(grades);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }

    }
}
