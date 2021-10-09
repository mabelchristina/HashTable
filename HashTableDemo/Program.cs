using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MapDemo<string, string> hash = new MapDemo<string, string>(6);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);

        }
    }
}
