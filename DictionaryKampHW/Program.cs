using System;
using System.Collections.Generic;

namespace DictionaryKampHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("book", "kitap");
            Console.WriteLine();

            Dictionary<string, string> dic = new Dictionary<string, string>();
        }
    }
}
