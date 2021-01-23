using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Tekirdağ");
            Console.WriteLine(cities.Count);

            MyList<string> cities1 = new MyList<string>();
            cities1.Add("Tekirdağ");
        }
    }
}

class MyList<T> //Generic class.
{
    public void Add(T item) 
    {
        
    }

}