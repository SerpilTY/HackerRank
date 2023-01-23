using System.Dynamic;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution 
        */

        Queue<int> myQueue=new Queue<int>();
        string choice;
        int q=Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= q; i++)
        {
            choice=(Console.ReadLine());
            if(choice.StartsWith("1")){
                string[] str=choice.Split(' ').ToArray();
                int a=Convert.ToInt32(str[1]);
                myQueue.Enqueue(a);
            }
            if(choice=="2"){
                myQueue.Dequeue();
            }
            if(choice=="3"){
                Console.WriteLine(myQueue.Peek()); 
            }
        }
    }
}