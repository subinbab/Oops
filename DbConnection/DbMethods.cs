using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class DbMethods : OpenConnection
    {
        public DbMethods(string connectionstring) : base(connectionstring)
        {

        }
    }
}
