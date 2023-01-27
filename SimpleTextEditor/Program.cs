using System.Security.Cryptography;
using System.Xml.Linq;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        string S = "";
        int depth = Convert.ToInt32(Console.ReadLine());
        List<int> queryNumbers = new List<int>();
        List<List<char>> concatteds = new List<List<char>>();
        List<List<char>> removedOnes = new List<List<char>>();


        for (int i = 1; i <= depth; i++)
        {
            string choice = Console.ReadLine();
            int queryNumber = Convert.ToInt32(choice.Split(' ')[0]);

            if (queryNumber == 1)
            {
                S += choice.Split(' ')[1];
                queryNumbers.Add(queryNumber);
                concatteds.Add((choice.Split(' ')[1]).ToList());
            }
            if (queryNumber == 2)
            {
                int a = (Convert.ToInt32((choice.Split(' ')[1])));
                removedOnes.Add(S.Substring(S.Length - a).ToList());
                S = S.Remove(S.Length - a, a);
                queryNumbers.Add(queryNumber);
            }
            if (queryNumber == 3)
            {   
                queryNumbers.Add(queryNumber);
                int index = (Convert.ToInt32((choice.Split(' ')[1]))) - 1;
                if (index <= S.Length - 1)
                {
                    Console.WriteLine(S[index]);
                }
                else continue;
            }
            if (queryNumber == 4)
            {
                int sequence = 1;
                queryNumbers.Add(queryNumber);
                foreach (var item in queryNumbers)
                {
                    if (item == 4) {sequence= sequence+1;
                    System.Console.WriteLine("sequence= " + sequence);}

                }

                if (queryNumbers[(queryNumbers.Count) - sequence] == 1)
                {
                    string myStr = new string(concatteds.Last().ToArray());
                    int index = S.IndexOf(myStr);
                    System.Console.WriteLine("index= " + index);

                    S = S.Remove(index, myStr.Length);
                    System.Console.WriteLine(S + "S: 4-1 SONRASI");
                }
                else if
                 (queryNumbers[(queryNumbers.Count) - sequence] == 2)
                {
                    string myStr = new string(removedOnes.Last().ToArray());
                    S += myStr;
                    System.Console.WriteLine(S + "S: 4-2 SONRASI");
                }
                else if
                 (queryNumbers[(queryNumbers.Count) - sequence] == 3)
                
                    continue;
            }
        }
    }
}

/*
Test Values
1 abc
3 3
2 3
1 xy
3 2
4
4
3 1


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    /*
    1. append - Append string  to the end of .
    2. delete - Delete the last  characters of .
    3. print - Print the  character of .
    4. undo - Undo the last (not previously undone) operation of type  or , reverting  to the state it was in prior to that operation.
      
    static void CheckCommand(ref Stack<Tuple<int, string>> stackCommands, Tuple<int, string> command, ref string text, bool isUndo = false) {
        Tuple<int, string> undoCommand;
        int k;
    
        switch (command.Item1) {
            case 1:
                string textToAppend = command.Item2;
                undoCommand = Tuple.Create(2, textToAppend.Length.ToString());
                              
                if (!isUndo) {
                    stackCommands.Push(undoCommand);
                }

                text += command.Item2;
                break;
            case 2:
                k = Convert.ToInt32(command.Item2);
                int deleteFrom = text.Length - k;
                undoCommand = Tuple.Create(1, text.Substring(deleteFrom));  
                 
                if (!isUndo) {                                 
                    stackCommands.Push(undoCommand);
                }

                text = text.Remove(deleteFrom);
                break;
            case 3:
                k = Convert.ToInt32(command.Item2);
                Console.WriteLine(text[k - 1]);
                break;
            case 4:
                undoCommand = stackCommands.Pop();
                CheckCommand(ref stackCommands, undoCommand, ref text, true);
                break;
            default:
                break;
        }
        
    }
    
    static void CheckCommandList(List<Tuple<int, string>> input) {
        string text = "";
        Stack<Tuple<int, string>> stackCommands = new Stack<Tuple<int, string>>();
        
        foreach (Tuple<int, string> command in input)
        {
            CheckCommand(ref stackCommands, command, ref text);
            
        }        
    }
    
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        List<Tuple<int, string>> input = new List<Tuple<int, string>>();
        
        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            
            int q = Convert.ToInt32(firstMultipleInput[0]);
            string attrs = q == 4 ? "" : firstMultipleInput[1];
            input.Add(Tuple.Create(q, attrs));
        }
        
        CheckCommandList(input);
    }
}

*/