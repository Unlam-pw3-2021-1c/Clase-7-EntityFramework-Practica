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

        public void Alta(Local local)
        {
            _dbContext.Locals.Add(local);
            _dbContext.SaveChanges();
        }
    }
}
