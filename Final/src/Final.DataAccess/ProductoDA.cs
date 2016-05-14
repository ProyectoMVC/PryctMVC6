using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Final.Entities;

namespace Final.DataAccess
{
    public class ProductoDA:IBase<Producto>
    {
        EStoreContext context = new EStoreContext();

        public bool Delete(Producto entidad)
        {
            context.Producto.Attach(entidad);
            context.Producto.Remove(entidad);
            return context.SaveChanges() >0;
        }

        public int Insert(Producto entidad)
        {
            context.Producto.Add(entidad);
            return context.SaveChanges();
        }

        public IEnumerable<Producto> SelectAll()
        {
            return context.Producto.Where(x => x.FlagAnulado == false).ToList();
        }

        public Producto SelectById(Producto entidad)
        {
            return context.Producto.SingleOrDefault(x => x.IdProducto == entidad.IdProducto && x.FlagAnulado == false);
        }

        public bool Update(Producto entidad)
        {
            context.Producto.Attach(entidad);
            context.Entry(entidad).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }
    }
}
