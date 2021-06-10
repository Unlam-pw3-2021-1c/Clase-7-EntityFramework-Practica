using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public partial class Prendum
    {
        public override string ToString()
        {
            return $"{Marca}-{Modelo}-{Tela}-{Talle}-{Color}-{Temporada}"; 
        }
    }
}
