using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class ProductoVendido
    {
        public ProductoVendido()
        {
            this.IdProductoVendido = 0;
            this.PVIdProducto = 0;
            this.PVStock = 0;
            this.PVIdVenta = 0;
        }
        public ProductoVendido(int idProductoVendido, int idProducto, int idVenta, double stock)
        {
            this.IdProductoVendido = idProductoVendido;
            this.PVIdProducto = idProducto;
            this.PVStock = stock;
            this.PVIdVenta = idVenta;
        }

        public int IdProductoVendido { get; set; }
        public int PVIdProducto { get; set; }
        public double PVStock { get; set; }
        public int PVIdVenta { get; set; }


    }
}
