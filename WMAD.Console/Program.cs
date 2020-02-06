using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMAD.ClassLibs;

namespace WMAD.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.DateOfBirth = new DateTime(2015, 2, 7);
            p.LaidOff = false;
            p.Name = "Aline Vetrov";

            string str = $"{p.Name} {p.Company} {p.Age}";

            System.Console.WriteLine(str);
            System.Console.ReadLine();
        }
    }
}
