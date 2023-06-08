using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x1 ="abc"; string x2 = "vyz";

            Swap(ref x1, ref x2);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");

            Console.ReadLine();

        }

        static void Swap<T>(ref T a, ref T b)
        {
            var temp = a; a = b; b = temp;

        }


        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
