using Final.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Business.Interfaces
{
    public interface IProductoBus
    {
        IEnumerable<Producto> SelectAll();

        Producto SelectById(Producto entidad);

        int Insert(Producto entidad);

        bool Update(Producto entidad);

        bool Delete(Producto entidad);
    }
}
