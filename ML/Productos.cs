using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Productos
    {
        public int IdProductos { get; set; }
        public string NombreProducto { get; set; }
        public string NumMaterial { get; set; }
        public int Inventario { get; set; }
        public ML.DivSubcategorias DivSubcategorias { get; set;}

    }
}
