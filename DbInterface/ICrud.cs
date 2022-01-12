using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbInterface
{
    public interface ICrud
    {
        bool Create<T>(T userData);
        T Get<T>();
        T GetById<T>(int id);
        bool Delete(int id);
        bool Edit<T>(T userData);
    }
}
