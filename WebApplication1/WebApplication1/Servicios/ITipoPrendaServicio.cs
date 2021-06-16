using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    interface ITipoPrendaServicio
    {
        TipoPrendum ObtenerPorId(int id);
        void Alta(TipoPrendum o);
        List<TipoPrendum> ObtenerTodos();
        void Borrar(TipoPrendum o);
    }
}
