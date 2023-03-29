using System.Collections.Specialized;
using System.Xml.Linq;
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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {

        /* 07:05:45PM
        19:05:45 */

        //DateTime Solution
        DateTime time=Convert.ToDateTime(s);
        System.Console.WriteLine(time.TimeOfDay);

        //Manuel Solution
        List<string> sections = s.Split(":").ToList();
        int hour = Convert.ToInt32(sections[0]);
        List<char> characters = sections[2].ToCharArray().ToList();
        string x = "";
        string y = "";
        string result = "";
        
        if (characters[2].Equals('P'))
        {
            x = Convert.ToString(characters[0]);
            y = Convert.ToString(characters[1]);
            if (hour == 12) { result = (hour + ":" + sections[1] + ":" + x + y); }
            else result = (hour + 12 + ":" + sections[1] + ":" + x + y);
        }
        else if (characters[2].Equals('A'))
        {
            x = Convert.ToString(characters[0]);
            y = Convert.ToString(characters[1]);
            if (hour == 12) { result = ("00:" + sections[1] + ":" + x + y); }
            else result = (sections[0] + ":" + sections[1] + ":" + x + y);

        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        string s = "07:05:45PM";
        System.Console.WriteLine(Result.timeConversion(s));
    }
}