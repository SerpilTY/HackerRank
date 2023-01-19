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
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        string result = "";
        if (grid.Count == 1) result = "YES";
        List<List<char>> gridy = new List<List<char>>();
        foreach (var item in grid)
        {
            gridy.Add(item.ToCharArray().ToList());
        }

        for (var i = 0; i < gridy.Count; i++)
        {
            for (var j = 0; j < gridy[i].Count; j++)
            {
                gridy[i].Sort();

            }
        }

        for (var k = 0; k < gridy.Count - 1; k++)
        {
            for (var l = 0; l < gridy[k].Count; l++)
            {

                if (gridy[k][l].GetHashCode() <= (gridy[k + 1][l]).GetHashCode())
                {
                    result = "YES";
                }
                if ((gridy[k][l].GetHashCode() > (gridy[k + 1][l]).GetHashCode()))
                {
                    result = "NO";
                    break;
                }
            }
            if (result == "NO") break;
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        //List<string> grid = new List<string>(){"ebacd", "fghij", "olmkn", "trpqs", "xywuv"} ;

        //List<string> grid = new List<string>(){"abc", "lmp", "qrt"} ;

        //List<string> grid = new List<string>(){"mpxz", "abcd", "wlmf"} ;

        //List<string> grid = new List<string>(){"hcd", "awc", "shm"} ;

        //List<string> grid = new List<string>(){"sur", "eyy", "gxy"} ;

        //List<string> grid = new List<string>(){"nyx", "ynx", "xyt"} ;

        //List<string> grid = new List<string>(){"zzzzzzzzzz", "zzzzzzzzzz", "zzzzzzzzzz", "zzzzzzzzzz", "zzzzzzzzzz"} ;

        //List<string> grid = new List<string>(){"vpvv", "pvvv", "vzzp","zzyy"} ;

        //List<string> grid = new List<string>(){"abc", "hjk", "hjk","rtv"} ;

        List<string> grid = new List<string>() { "mpxz", "abcd", "wlmf" };


        string result = Result.gridChallenge(grid);

        Console.WriteLine(result);
    }

}

/*    System.Console.Write(gridy[i][j]+" [i][j]=["+(i)+"]["+(j)+"] ");
             System.Console.Write(gridy[i][j].GetHashCode()+" "); */

/*  System.Console.Write( gridy[k][l]+" [k][l]=["+k+"]["+l+"] ");
                 System.Console.Write( gridy[k+1][l]+" [k+1][l]=["+ (k+1)+"]["+l+"] ");
                 System.Console.WriteLine(); */