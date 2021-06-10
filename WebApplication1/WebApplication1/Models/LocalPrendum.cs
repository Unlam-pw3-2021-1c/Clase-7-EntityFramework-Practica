using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class LocalPrendum
    {
        public int IdLocal { get; set; }
        public int IdPrenda { get; set; }

        public virtual Local IdLocalNavigation { get; set; }
        public virtual Prendum IdPrendaNavigation { get; set; }
    }
}