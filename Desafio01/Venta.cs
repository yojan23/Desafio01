using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Venta
    {
        public int VentaId { get; set; }
        public string Comentarios { get; set; }
        public int VUserId { get; set; }
        public Venta(int idVenta, string comentarios, int idUsuario)
        {
            this.VentaId = idVenta;
            this.Comentarios = comentarios;
            this.VUserId = idUsuario;
        }
    }
}
