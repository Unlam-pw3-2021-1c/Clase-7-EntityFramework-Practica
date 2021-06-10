using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Servicios
{
    public class PrendaServicio : IPrendaServicio
    {
        private VestimentasDBContext _dbContext;
        public PrendaServicio(VestimentasDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public Prendum ObtenerPorId(int id)
        {
            return _dbContext.Prenda
                .Include(o=> o.LocalPrenda)
                .Include("LocalPrenda.IdLocalNavigation")
                .FirstOrDefault(o=> o.IdPrenda == id);
        }

        public List<Prendum> ObtenerPorIds(int[] ids)
        {
            return _dbContext.Prenda
                .Include(o => o.LocalPrenda)
                .Include("LocalPrenda.IdLocalNavigation")
                .Where(o => ids.Contains(o.IdPrenda)).ToList();
        }

        public List<Prendum> ObtenerTodos()
        {
            return _dbContext.Prenda.ToList();
        }

        public void Alta(Prendum prenda)
        {
            _dbContext.Prenda.Add(prenda);
            _dbContext.SaveChanges();
        }

        public void Borrar(Prendum prenda)
        {
            _dbContext.Prenda.Remove(prenda);
            _dbContext.SaveChanges();
        }
    }
}
