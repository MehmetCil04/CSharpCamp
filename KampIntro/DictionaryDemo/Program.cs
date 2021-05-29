using System;

namespace DictionaryDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Fizik", 75);
            myDictionary.Add("Matematik", 85);

            Console.WriteLine(myDictionary.Lengh);
            
        }
    }
}
