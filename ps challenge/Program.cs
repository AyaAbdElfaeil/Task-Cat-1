
using System;
using System.Collections.Generic;

class Program
{
   
    static void Main() { 
   
        List<string> words = new List<string>  ();
        words.Add("code");
        words.Add("backend");
        words.Add("ai");
        words.Add("circle");
        string shortest = words[0];
        for (int i=0;i<words.Count;i++)
        {if (words[i].Length < shortest.Length)
            {
                shortest = words[i];
                
            }
        }
        Console.WriteLine(shortest);
  
    }
}