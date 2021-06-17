using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Models;

namespace Servicios
{
    public interface IPrendaServicio
    {
        Prendum ObtenerPorId(int id);
        void Alta(Prendum o);
        List<Prendum> ObtenerPorIds(int[] ids);
        List<Prendum> ObtenerTodos();
        List<Prendum> ObtenerTodosPorTipoPrenda(int idTipoPrenda);
        void Borrar(Prendum o);
    }
}
