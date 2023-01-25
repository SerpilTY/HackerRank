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
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        Stack<char> myStack = new Stack<char>();
        char[] myChars = s.ToCharArray();
        string result = "";

        for (var k = 0; k < (myChars.Length) / 2; k++)
        {
            myStack.Push(myChars[k]);

        }


        if(myChars.Length%2==1) result="NO";  
        else{

        for (int i = (myChars.Length) / 2; i < (myChars.Length/ 2)+1; i++)
        { 
     
            if (myChars[i] == ')' && myStack.First() == '(') {

                 result = "YES"; }
            else if (myChars[i] == ']' && myStack.First() == '[') {
    
                 result = "YES"; }
            else if (myChars[i] == '}' && myStack.First() == '{') {
      
                 result = "YES"; } else { 
           result = "NO"; break; }
                    
        for (int j = (myChars.Length) / 2; j < (myChars.Length); j++)
        {
            if (myChars[j] == ')' && myStack.Contains('(')) { result = "YES"; }
            else if (myChars[j] == ']' && myStack.Contains('[')) { result = "YES"; }
            else if (myChars[j] == '}' && myStack.Contains('{')) { result = "YES"; }
            else if (myChars[j] == '(' && myStack.Contains(')')) { result = "YES"; }
            else if (myChars[j] == '[' && myStack.Contains(']') ) { result = "YES"; }
            else if (myChars[j] == '{' && myStack.Contains('}')) { result = "YES"; }

            else { result = "NO"; break; }
        }
        }}
        

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        string s = "{(([])[])[]}";

        string result = Result.isBalanced(s);

        Console.WriteLine(result);
    }

}

