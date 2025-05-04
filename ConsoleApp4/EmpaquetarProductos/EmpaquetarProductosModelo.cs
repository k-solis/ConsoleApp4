using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp4.EmpaquetarProductos
{
    internal class EmpaquetarProductosModelo
    {
        public List<OrdenPreparacion> OrdenesEnPreparacionDisponibles { get; set; }
        public List<Producto> ProductosOrden { get; set; }


        public EmpaquetarProductosModelo()
        {
            //hardcodeamos datos
            OrdenesEnPreparacionDisponibles =
            [
                new OrdenPreparacion { NumeroOrden = 1},
                new OrdenPreparacion { NumeroOrden = 2},
                new OrdenPreparacion { NumeroOrden = 3},
                new OrdenPreparacion { NumeroOrden = 4},
                new OrdenPreparacion { NumeroOrden = 5},
                new OrdenPreparacion { NumeroOrden = 6},
                new OrdenPreparacion { NumeroOrden = 7},
                new OrdenPreparacion { NumeroOrden = 8},
                new OrdenPreparacion { NumeroOrden = 9},
                new OrdenPreparacion { NumeroOrden = 10}
            ];

            ProductosOrden = new List<Producto>
            {
                new Producto(1, "Laptop", 10),
                new Producto(2, "Mouse óptico", 25),
                new Producto(3, "Teclado mecánico", 50),
                new Producto(4, "Monitor LED 24''", 15),
                new Producto(5, "Impresora láser", 8),
                new Producto(6, "Silla ergonómica", 5),
                new Producto(7, "Disco duro SSD 1TB", 30),
                new Producto(8, "Auriculares inalámbricos", 40),
                new Producto(9, "Tablet 10''", 20),
                new Producto(10, "Cámara web HD", 12),
            };

        }
        //Cambiar estado de orden de "en preparacion" a "preparada"
        //Salir
        //Confirmar
    }
}
