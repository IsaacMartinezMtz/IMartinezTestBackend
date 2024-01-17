using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class SubCategoria
    {
        public int IdSubcategorias { get; set; }
        public string Nomnbre { get; set; }
        public ML.Categorias Categorias { get; set; }
    }
}
