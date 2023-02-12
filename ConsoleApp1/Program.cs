using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahmed Ismail
            Console.WriteLine(SayHello());
            Console.WriteLine(SayHello("Ahmed Ismaeil"));
          
        }
        static string SayHello()
        {
            string name = "Ahmed";
            return name;
        }
        static string SayHello(string name)
        {
            string fullname = name + " Family Name";
            return fullname;
        }
    }
}
