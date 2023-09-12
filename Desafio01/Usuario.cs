using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Usuario
    {
        public int UserId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }
        public Usuario()
        {
            this.UserId = 0;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
            this.NombreUsuario = String.Empty;
            this.Contrasenia = String.Empty;
            this.Mail = String.Empty;
        }
        public Usuario(int idUsuario, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.UserId = idUsuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contrasenia = contrasenia;
            this.Mail = mail;
        }
    }
}
