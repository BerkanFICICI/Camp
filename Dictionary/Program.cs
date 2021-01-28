using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> numberNames = new Dictionary<string, string>();
            numberNames.Add("bir", "One"); //adding a key/value using the Add() method
            numberNames.Add("iki", "Two");
            numberNames.Add("üç", "Three");
            Console.WriteLine(numberNames["bir"]); //printing value of key 1.
        }
    }
}
