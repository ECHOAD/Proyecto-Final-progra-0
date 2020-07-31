using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba2
{
    public static class CL_Validaciones
    {

        public static string validar()
        {

            Console.WriteLine("*************** Ingrese el usuario ***************");

            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string pass = Console.ReadLine();

            bool usuarioExiste = false;


            string[,] usuarioGeneral = CL_usuarios.LLenarTablaUsuario();
            DateTime[] Fecha = CL_usuarios.returFecha();

            for (int i = 0; i < Fecha.Length; i++)
            {
                if (usuario == usuarioGeneral[i, 1] && pass == usuarioGeneral[i, 2])
                {
                    usuarioExiste = true;
                    if ("Activo" == usuarioGeneral[i, 4])
                    {
                        Console.WriteLine("**************************************************************************************");
                        Console.WriteLine($"Hola, {usuarioGeneral[i, 0]} ,Acabas de ingresar con el usuario '{usuarioGeneral[i, 1]}' y su rol es *{usuarioGeneral[i, 3]}*." + $" \n {Fecha[i]} ");
                        Console.WriteLine("Bienvenido!");

                    }
                    else
                    {
                        Console.WriteLine("**************************************************************************************");
                        Console.WriteLine($"Hola, {usuarioGeneral[i, 0]} ,Acabas de ingresar con el usuario '{usuarioGeneral[i, 1]}' y su rol es *{usuarioGeneral[i, 3]}*." + $" \n {Fecha[i]} ");
                        Console.WriteLine("**************************************************************************************");
                        Console.WriteLine();

                        Console.WriteLine($" Pero lamentablemente tu usuario esta inactivo  , tienes que inciar sesion con otro usuario, por favor comunicate con el administardor cuyo usuario es *{usuarioGeneral[2, 1]}* " + " \n");

                        CL_usuarios.LLenarTablaUsuario();
                    }

                    break;
                }

            }

            if (usuarioExiste == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("                    ERROR");

                Console.WriteLine(" *********************************************");
                Console.WriteLine("Usuario o Contraseña invalida, Trate de nuevo ");
                Console.WriteLine(" *********************************************");

                Console.WriteLine("");
                CL_usuarios.LLenarTablaUsuario();
            }

            Console.WriteLine("***************[Desea salir ?]***************");
            string valor;
            bool salida=false;
            do
            {
                Console.Write(" Si / NO : ");
                valor = Console.ReadLine().ToUpper();
                if (valor == "SI" || valor == "NO")
                {
                    salida = true;
                }

           
            } while (salida==false);


            if (valor == "SI")
            {
                return "exit";
            }


            return "";
        }
    }
}
