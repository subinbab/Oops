using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DbInterface;

namespace DbConnection
{
    public class DbTable<T> : ICrud
    {
        private string tableName = null;
        public DbTable(string  tablename)
        {
            tableName = tablename;
        }
        public bool Create<T1>(T1 userData)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit<T1>(T1 userData)
        {
            throw new NotImplementedException();
        }

        public T1 Get<T1>()
        {
            throw new NotImplementedException();
        }

        public T1 GetById<T1>(int id)
        {
            throw new NotImplementedException();
        }
        public void Display(T modelData)
        {
            Type tModelType = modelData.GetType();
            PropertyInfo[] arrayPropertyInfos = tModelType.GetProperties();
            foreach (PropertyInfo property in arrayPropertyInfos)
            {
                Console.WriteLine("Name of Property is\t:\t" + property.Name);
                Console.WriteLine("Value of Property is\t:\t" + property.GetValue(modelData).ToString());
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
