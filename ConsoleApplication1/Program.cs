using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosMYSQL;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             Usuarios usuario = new Usuarios();
             usuario.Idusuario = "kev95p";
             usuario.Nombres = "KEVIN";
             usuario.Apellidos = "Pleitez";
             usuario.Email = "pleitez95geova@gmail.com";
            usuario.Telefono = "1239393";
            usuario.Clave = "admin";
             
            /*Paises p = new Paises();
            p.Pais = "El Salvador";*/

            EntityQueryBuild ent = new EntityQueryBuild(usuario);     
            Console.WriteLine(ent.getSelect("kev95p"));
           Console.ReadKey();
           
        }
    }
}
