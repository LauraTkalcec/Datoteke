using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program cita iz datoteke\n");

            try
            {
                using (StreamReader sr = new StreamReader("Test.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Datoteka se ne moze otvoriti\n");
                Console.WriteLine(e.Message);
            }
        }
    }
}
