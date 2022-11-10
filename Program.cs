using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apptec2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string nombre, apellido, direccion, celular, perfil, usuarioAcceso, contraseña, confirmcontraseña;
            byte edadUsuario;
            #region Edad usuario
            //Edad Del Usuario
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Escribe tu edad");
                edadUsuario = Convert.ToByte(Console.ReadLine());
            }
            #endregion
            //condicion usuario mayoria de edad
            if (edadUsuario >= 18)
            {
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Escribe tu nombre o nombres");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Escribe tu numero de telefono y despues dale enter");
                    celular = Console.ReadLine();
                    Console.WriteLine("Escribe tu perfil de facebook");
                    perfil = Console.ReadLine();
                    Console.WriteLine("Escribe tu direccion");
                    direccion = Console.ReadLine();
                    Console.WriteLine("ingresa tu apellido");
                    apellido = Console.ReadLine();
                    Console.WriteLine("ingresa tu nombre de usuario");
                    usuarioAcceso = Console.ReadLine();
                    Console.WriteLine("Ingresa tu contraseña");
                    contraseña = Console.ReadLine();
                    Console.WriteLine("Confirma tu contraseña");
                    confirmcontraseña = Console.ReadLine();
                }
                Console.Clear();
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n informacion de registro");
                    Console.WriteLine("\n nombre/s: {0},\n Celular:{1}, \n perfil: {2}, \n direccion: {3}, \n apellido: {4}, \n usuario acceso: {5},", nombre, celular, perfil, direccion, apellido, usuarioAcceso);
                }

                #region codigo aleatorio
                if (contraseña == confirmcontraseña)
                {
                    //Numero aleatorio

                    Random Aleatorio = new Random();
                    int codigo = Aleatorio.Next(1000, 9999);
                    Console.WriteLine("\n codigo acceso:" + codigo);
                    Console.ReadLine();
                }
                #endregion
            }
            #region el usuario no es mayor de edad
            else
            {
                Console.WriteLine("No eres mayor de edad");
                Console.ReadLine();
            }
            #endregion
        }
    }
}
