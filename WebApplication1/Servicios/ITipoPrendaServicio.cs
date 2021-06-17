using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Models;

namespace Servicios
{
    public interface ITipoPrendaServicio
    {
        TipoPrendum ObtenerPorId(int id);
        void Alta(TipoPrendum o);
        List<TipoPrendum> ObtenerTodos();
        void Borrar(TipoPrendum o);
    }
}
