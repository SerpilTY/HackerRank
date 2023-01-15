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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        List<char> letters = new List<char>();
        char[] lowerCase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        foreach (var item in lowerCase)
        {   letters.Add(item);   }

        for (int i = 0; i < k; i++)
        {   char temp = letters[i];
            letters.Add(temp);   }

        letters.RemoveRange(0, k);

        List<char> myStringToChar = s.ToCharArray().ToList();
        List<char> myCryptedTinyChars = new List<char>();

        for (int j = 0; j < myStringToChar.Count; j++)
        {
        for (int i = 0; i < lowerCase.Length; i++){ 
        if (!char.IsLetterOrDigit(myStringToChar[j])) { 
                myCryptedTinyChars.Add(myStringToChar[j]); break; }

        if (myStringToChar[j] == lowerCase[i])   
                myCryptedTinyChars.Add(letters[i]);

        if (myStringToChar[j] == char.ToUpper(lowerCase[i])) 
                myCryptedTinyChars.Add(char.ToUpper(letters[i]));
                
        if (char.IsNumber(myStringToChar[j])) { 
                myCryptedTinyChars.Add(myStringToChar[j]); break; }
            } }

        string str = new string(myCryptedTinyChars.ToArray());
        System.Console.WriteLine(str);

        return str;
    } }

class Solution
{
    public static void Main(string[] args)
    {


        int n = 11;
        //Convert.ToInt32(Console.ReadLine().Trim());

        string s = "157Always4869***Always-Look-on-the-Bright-Side-of-Life";
        //Console.ReadLine();

        int k = 5;
        //Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

    }
}
