using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float PrecioVenta { get; set; }
        public double Stock { get; set; }
        public int PUserID { get; set; }
        public Producto()
        {
            this.IdProducto = 0;
            this.Descripcion = String.Empty;
            this.Costo = 0;
            this.Stock = 0;
            this.PUserID = 0;
            this.PrecioVenta = 0;
        }
        public Producto(int idProducto, string descripcion, float costo, float precioVenta, double stock, int idUsuario)
        {
            this.IdProducto = idProducto;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.Stock = stock;
            this.PUserID = idUsuario;
            this.PrecioVenta = precioVenta;
        }
    }
}
