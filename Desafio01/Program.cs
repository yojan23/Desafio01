// See https://aka.ms/new-console-template for more information
using Desafio01;
using System.Reflection;

string User01 = String.Empty;
string Password01 = String.Empty;
int U_attempts = 0;
int P_attempts = 0;
string option = String.Empty;
int i = 0;

Usuario usuario = new Usuario(5653, "juan", "Perez", "juan-23", "23juan23", "juanpe@gmail.com");

Usuario usuario2 = new Usuario(5656, "Jose", "Paez", "jose-23", "23jose23", "josepa@gmail.com");

Producto producto = new Producto(2432, "iPhone 15 256GB", 1250, 1499.99f, 34, 5653);

ProductoVendido productoVendido = new ProductoVendido(231, 2432, 32444, 34);

Venta venta = new Venta(32444, "Producto Nuevo", 5656);

Console.WriteLine("!!!!!!!!!!!!!!!!!Bienvenido a Portal Compras!!!!!!!!!!!!!!!!!!!!");


while (!User01.Equals(usuario.NombreUsuario) && U_attempts < 4)
{
    Console.WriteLine("User: ");
    User01 = Console.ReadLine();
    if (!User01.Equals(usuario.NombreUsuario))
    {
        Console.WriteLine("!!!User Does Not Exist!!!");
        Console.WriteLine("Please Renter User");
    }
    U_attempts++;
    if (U_attempts == 4)
    {
        Console.WriteLine("Max number of attempts for User");
    }
    if (User01.Equals(usuario.NombreUsuario))
    {
        while (!Password01.Equals(usuario.Contrasenia) && P_attempts < 4)
        {
            Console.WriteLine("Password: ");
            Password01 = Console.ReadLine();
            if (!Password01.Equals(usuario.Contrasenia))
            {
                Console.WriteLine("!!!Password Incorrect!!!");
                Console.WriteLine("Please Renter Password");
            }
            P_attempts++;
            if (P_attempts == 4)
            {
                Console.WriteLine("Max number of attempts for Password");
            }
            if (Password01.Equals(usuario.Contrasenia))
            {
                while ( i < 10)
                {
                    i++;
                    Console.WriteLine("!!!!!!!!!!!!!!!!!Bienvenido Juan!!!!!!!!!!!!!!!!!!!!" + Environment.NewLine
                                  + "Marque una opcion:" + Environment.NewLine
                                  + "Opcion 1: Datos Personales" + Environment.NewLine
                                  + "Opcion 2: Productos" + Environment.NewLine
                                  + "Opcion 3: Productos Vendidos" + Environment.NewLine
                                  + "Opcion 4: Ventas" + Environment.NewLine
                                  + "Opcion 5: Salir");
                    option = Console.ReadLine();
                    if (option == "1")
                    {
                        i = 0;
                        Console.WriteLine("UserName: " + usuario.NombreUsuario + Environment.NewLine
                       + "ID de Usuario:  " + venta.VUserId + Environment.NewLine
                       + "Nombre Completo: " + usuario.Nombre + " " + usuario.Apellido + Environment.NewLine
                       + "Email: " + usuario.Mail);
                    }
                    if (option == "2")
                    {
                        i = 0;
                        Console.WriteLine("ID de Producto: " + producto.IdProducto + Environment.NewLine
                   + "Descripcion: " + producto.Descripcion + Environment.NewLine
                   + "Costo: " + producto.Costo + Environment.NewLine
                   + "Precio: " + producto.PrecioVenta + Environment.NewLine
                   + "Stock: " + producto.Stock + Environment.NewLine
                   + "ID de Usuario: " + usuario.UserId);
                    }
                    if (option == "3")
                    {
                        i = 0;
                        Console.WriteLine("ID de Producto Vendido: " + productoVendido.IdProductoVendido + Environment.NewLine
                   + "ID de Producto:  " + productoVendido.PVIdProducto + Environment.NewLine
                   + "Stock: " + productoVendido.PVStock + Environment.NewLine
                   + "ID de Venta: " + productoVendido.PVIdVenta);
                    }
                    if (option == "4")
                    {
                        i = 0;
                        Console.WriteLine("ID de Venta: " + venta.VentaId + Environment.NewLine
                   + "Comentarios:  " + venta.Comentarios + Environment.NewLine
                   + "ID de usuario: " + venta.VUserId);
                    }
                    if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5")
                    {
                        Console.WriteLine("!!!!Opcion Invalida!!!!");
                    }
                    if (option == "5")
                    {
                        i = 10;
                        Console.WriteLine("!!!!Gracias por visitarnos Hasta la Proxma!!!!");
                    }

                }
            }
        }
    }
}
