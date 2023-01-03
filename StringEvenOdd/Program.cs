using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n=Convert.ToInt32(Console.ReadLine());
        
        string[] phase=new string[n];

        for (int i = 0; i <n; i++)
        {
            phase[i]=Console.ReadLine();
            
        }
        

     List<char> newevencharacters=new List<char>();
     List<char> newoddcharacters=new List<char>();
     char[] characters;
     foreach (var item in phase)
     {
        characters=item.ToCharArray();
     
    for (int j = 0; j < characters.Length; j++)
        {
            
            if(j%2==0){ newevencharacters.Add(characters[j]);}
            else if(j%2!=0){newoddcharacters.Add(characters[j]);}
        }
        foreach (var x in newevencharacters)
    {
        System.Console.Write(x);
    }
     System.Console.Write(" ");
     foreach (var y in newoddcharacters)
     {
        System.Console.Write(y);
     }
     System.Console.WriteLine();
        newevencharacters.Clear();
        newoddcharacters.Clear();
    
}




    /* string sentence=Console.ReadLine();
    string[] words=sentence.Split(" ");
    List<char> newevencharacters=new List<char>();
     List<char> newoddcharacters=new List<char>();
    for (int i = 0; i < words.Length; i++)
    {
        char[] characters = words[i].ToCharArray();
        for (int j = 0; j < characters.Length; j++)
        {
            
            if(j%2==0){ newevencharacters.Add(characters[j]);}
            else if(j%2!=0){newoddcharacters.Add(characters[j]);}
        }
        
    }
    foreach (var item in newevencharacters)
    {
        System.Console.Write(item);
    }
     System.Console.Write("  ");
     foreach (var item in newoddcharacters)
     {
        System.Console.Write(item);
     } */

    }
}