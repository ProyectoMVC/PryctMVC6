using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.DataAccess
{
    interface IBase<T>
    {
        IEnumerable<T> SelectAll();
        T SelectById(T entidad);
        int Insert(T entidad);
        bool Update(T entidad);
        bool Delete(T entidad);
    }
}
