using DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenConnection db = new OpenConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=MobizoneV1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            db.TestDisplay("qwerty12345678");
            if (db.IsConnected())
            {
                Console.WriteLine("connected");
            }
            else
            {
                Console.WriteLine("not connected");
            }
            Console.ReadLine();
            DbTable<Create> dbtable = new DbTable<Create>("CreateTable");
            Create cr = new Create();
            cr.id = 1;
            cr.Firstname = "SUbin";
            cr.Lastname = "Babu";
            cr.Email = "subinbabu$127@gmail.com";
            cr.Password = "Subin@1999";
            dbtable.Display(cr);
        }
    }
}
