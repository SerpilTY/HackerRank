using System.Runtime.CompilerServices;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string, int> a = new Dictionary<string, int>();
        string name = "";
        int phoneNumber;
        System.Console.WriteLine("How much people will you record? ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            System.Console.WriteLine(" Enter name -sapace- phonenumber");
            string[] tokens = Console.ReadLine().Split();

            //Parse element 0
            name = tokens[0];

            //Parse element 1
            phoneNumber = int.Parse(tokens[1]);
            if (phoneNumber.ToString().Length == 8)
            {
                a.Add(name, phoneNumber);
            }
        }

        List<string> search = new List<string>();
        string b;
        System.Console.WriteLine("Write the name you will search:");
        while ((b = Console.ReadLine().ToLower()) != "")
        {
            search.Add(b);
        }
        foreach (var item in search)
        {
            if (a.ContainsKey(item))
                System.Console.WriteLine(item + "=" + a.GetValueOrDefault(item));
            else System.Console.WriteLine("Not found");

        }
    }
}

