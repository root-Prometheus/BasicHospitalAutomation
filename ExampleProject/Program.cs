using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace ExampleProject
{
    internal class Program
    {
        enum Days { Sun , Mon , tue , Wed , thu , Fri , Sat };
        static void Main(string[] args)
        {
            int WeekDayStart = (int)Days.Fri;
            WriteLine(WeekDayStart);
            WriteLine(Days.Sun);
            WriteLine("Hello");
            string name = "deniz";
            WriteLine("{name} {name}");
        }
    }
}
