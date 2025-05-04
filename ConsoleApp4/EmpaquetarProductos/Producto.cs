using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.EmpaquetarProductos
{
    internal class Producto
    {
        // Atributos
        public int SKUProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducto { get; set; }

        // Constructor
        public Producto(int skuProducto, string nombreProducto, int cantidadProducto)
        {
            SKUProducto = skuProducto;
            NombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
        }
    }
}
