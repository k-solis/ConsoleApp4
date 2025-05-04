using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.EmpaquetarProductos
{
    internal class EmpaquetarProductosModelo
    {
        public List<OrdenPreparacion> OrdenesEnPreparacionDisponibles { get; set; }

        public EmpaquetarProductosModelo()
        {
            var productosEjemplo = new List<Producto>
            {
                new Producto(1, "Laptop", 2),
                new Producto(2, "Mouse óptico", 5),
                new Producto(3, "Teclado mecánico", 3)
            };

            OrdenesEnPreparacionDisponibles = new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    NumeroOrden = 1,
                    EstadoOrden = "En Preparacion",
                    Productos = productosEjemplo
                },
                new OrdenPreparacion
                {
                    NumeroOrden = 2,
                    EstadoOrden = "En Preparacion",
                    Productos = new List<Producto>
                    {
                        new Producto(4, "Monitor LED", 1),
                        new Producto(5, "SSD", 2)
                    }
                }
            };
        }
    }
}
