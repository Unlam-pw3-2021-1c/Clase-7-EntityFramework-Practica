using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Models;

namespace Servicios
{
    public interface ILocalServicio
    {
        Local ObtenerPorId(int id);
        void Alta(Local local);
        void Modificar(Local local, List<Prendum> prendas);
        void Borrar(Local local);
    }
}
