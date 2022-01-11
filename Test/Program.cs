using DbConnection;
using System;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("You are in a test mode");
            DbMethods Db = new DbMethods("Data Source=(localdb)\\ProjectModels;Initial Catalog=WebApiVersion1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Db.TestDisplay("qwerty12345678");
        }
    }
}
