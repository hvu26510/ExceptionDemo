using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "Mr.A");
            hashtable.Add(2, "Mr.B");
            hashtable.Add(3, "Mr.C");
            hashtable.Add(4, "Mr.D");

            hashtable.Remove(1);

            foreach (DictionaryEntry entry in hashtable) 
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }

            Console.ReadLine();
        }
    }
}
