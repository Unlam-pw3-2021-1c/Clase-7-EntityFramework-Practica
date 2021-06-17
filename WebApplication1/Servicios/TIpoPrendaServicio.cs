using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;

namespace Servicios
{
    public class TipoPrendaServicio : ITipoPrendaServicio
    {
        private VestimentasDBContext _dbContext;
        public TipoPrendaServicio(VestimentasDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public TipoPrendum ObtenerPorId(int id)
        {
            return _dbContext.TipoPrenda
                .FirstOrDefault(o=> o.IdTipoPrenda == id);
        }

        public List<TipoPrendum> ObtenerTodos()
        {
            return _dbContext.TipoPrenda.ToList();
        }

        public void Alta(TipoPrendum tipoPrenda)
        {
            _dbContext.TipoPrenda.Add(tipoPrenda);
            _dbContext.SaveChanges();
        }

        public void Borrar(TipoPrendum tipoPrenda)
        {
            _dbContext.TipoPrenda.Remove(tipoPrenda);
            _dbContext.SaveChanges();
        }
    }
}
