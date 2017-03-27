using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{

    public class Usuarios : Entidad
    {



        public Usuarios()
        {
            init();
        }

        private string idusuario;
        private string nombres;
        private string apellidos;
        private string email;
        private string telefono;
        private string clave;
        private int idpais;
        private int idrol;

        public string Idusuario { get => idusuario; set => idusuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Idpais { get => idpais; set => idpais = value; }
        public int Idrol { get => idrol; set => idrol = value; }

        private void init()
        {
            PRIMARY_KEY = "Idusuario";
            AUTOINCREMENT = false;
        }



 
    }
}
