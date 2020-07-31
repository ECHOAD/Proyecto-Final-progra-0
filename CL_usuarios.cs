using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba2
{
    class CL_usuarios
    {      

            public static string[,] LLenarTablaUsuario()
            {
                string[,] Usuarios = new string[3, 5]
                {
                {"Raul Cervantes","0000000001", "1234","Supervisor","Activo"},
                {"Jose Guerrero", "0000000002", "4321","Vendedor","Inactivo"},
                {"Luke Soriano", "0000000003", "4132","Administrador","Activo"}
                };           

                return Usuarios;          
                           
            }

            public static DateTime[] returFecha()
            {                        
           
                DateTime[] FechaCreacion = { Convert.ToDateTime("05/03/2010"), Convert.ToDateTime("05/03/2012"), Convert.ToDateTime("05/03/2013") };         
                return FechaCreacion;      
             
            }

      

    }
}
