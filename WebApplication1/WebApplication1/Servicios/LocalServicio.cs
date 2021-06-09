using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    public class LocalServicio : ILocalServicio
    {
        private VestimentasDBContext _dbContext;
        public LocalServicio(VestimentasDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Local ObtenerPorId(int id)
        {
            return _dbContext.Locals.Find(id);
        }

        public void Alta(Local local)
        {
            _dbContext.Locals.Add(local);
            _dbContext.SaveChanges();
        }

        public void Modificar(Local local)
        {
            Local objActual = ObtenerPorId(local.IdLocal);
            objActual.Direccion = local.Direccion;
            objActual.Nombre = local.Nombre;
            _dbContext.SaveChanges();
        }

        public void Borrar(Local local)
        {
            _dbContext.Locals.Remove(local);
            _dbContext.SaveChanges();
        }
    }
}
