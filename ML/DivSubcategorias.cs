using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class DivSubcategorias
    {
        public int IdDivSubcategorias { get; set; }
        public string Nombre { get; set; }
        public ML.SubCategoria SubCategoria { get; set; }
    }
}
