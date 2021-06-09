using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    interface ILocalServicio
    {
        Local ObtenerPorId(int id);
        void Alta(Local local);
        void Borrar(Local local);
    }
}
