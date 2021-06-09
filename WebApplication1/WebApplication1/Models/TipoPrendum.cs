using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TipoPrendum
    {
        public TipoPrendum()
        {
            Prenda = new HashSet<Prendum>();
        }

        public int IdTipoPrenda { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Prendum> Prenda { get; set; }
    }
}
