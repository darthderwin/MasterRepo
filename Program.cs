using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(isPangram(s));
            Console.WriteLine(isPangram(sb));
        }

        public static bool isPangram(string s)
        {
            HashSet<char> hS = new HashSet<char>();
            foreach (char x in s)
            {
                if(char.IsLetter(x))
                {
                    hS.Add(x);
                    if(hS.Count == 26)
                    {
                        return true;
                    }
                    else if(hS.Count < 26)
                    {
                        return false;
                    }
                }          
            }
            return true;
        }

        public static void CreateString()
        {
            string sb = new string();           
        }
    }
}

// 1. 
// isPangram(string s)
// Add Char (_____sb, char x);
// isPangram(sb.GetAsString);

// 2. Insertion sort
// 3. Merge sort
// 4. Quicksort
// 5. Dijksins shorthest path
