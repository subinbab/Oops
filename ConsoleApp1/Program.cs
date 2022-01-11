using DbConnection;
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
            Console.WriteLine("You are in a test mode");
            OpenConnection OC = new OpenConnection();
            OC.TestDisplay("qwerty12345678");
            bool success = OC.IsConnected();
            if (success)
            {
                Console.WriteLine("success");
            }
            else
                Console.WriteLine("error");
            Console.ReadLine();

        }
    }
}
