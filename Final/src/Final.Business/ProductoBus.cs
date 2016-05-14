using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final.Entities;
using Final.DataAccess;
using Final.Business.Interfaces;

namespace Final.Business
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ProductoBus:IProductoBus
    {
        ProductoDA da = new ProductoDA();

        public bool Delete(Producto entidad)
        {
            return da.Delete(entidad);
        }

        public int Insert(Producto entidad)
        {
            return da.Insert(entidad);
        }

        public IEnumerable<Producto> SelectAll()
        {
            return da.SelectAll();
        }

        public Producto SelectById(Producto entidad)
        {
            return da.SelectById(entidad);
        }

        public bool Update(Producto entidad)
        {
            return da.Update(entidad);
        }
    }
}
