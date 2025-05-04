using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp4.EmpaquetarProductos
{
    class OrdenPreparacion
    {
        // Atributos.
        public int NumeroOrden { get; set; }
        public string EstadoOrden { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}







