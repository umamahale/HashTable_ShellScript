using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HashTableDemo
{
    class UC2HashTab
    {

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "“Paranoids");
            ht.Add("2", "are");
            ht.Add("3", "not");
            ht.Add("4", "paranoids");
            ht.Add("5", "because");
            ht.Add("6", "they");
            ht.Add("7", "are");
            ht.Add("8", "paranoid but");
            ICollection key = ht.Keys;
            Console.WriteLine("Retrieving all elements: ");
            Console.WriteLine();
            foreach (var k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            ArrayList al = new ArrayList(key);
            Console.WriteLine("Retrieving all keys in the arraylist");
            Console.WriteLine();
            foreach (var n in al)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
