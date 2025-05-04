using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;
//using GrupoD.Prototipo._4._Empaquetar_Productos;

namespace ConsoleApp4.EmpaquetarProductos
{
    class OrdenPreparacion
    {
        // Atributos.
        public int NumeroOrden { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public override string ToString()
        {
            return $"{NumeroOrden}";
        }
    }
}





