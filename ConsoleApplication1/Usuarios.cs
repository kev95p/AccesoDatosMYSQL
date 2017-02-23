using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosMYSQL;

namespace ConsoleApplication1
{

    public class Usuarios : Entidad
    {



        public Usuarios()
        {
            init();
        }

        private void init()
        {
            PRIMARY_KEY = "idusuario";
            AUTOINCREMENT = false;
        }

        private string idusuario;
        private string nombres;
        private string apellidos;
        private string email;
        private string telefono;
        private string clave;
        private int idpais;
        private int idrol;

        public string Idusuario
        {
            get
            {
                return idusuario;
            }

            set
            {
                idusuario = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public int Idpais
        {
            get
            {
                return idpais;
            }

            set
            {
                idpais = value;
            }
        }

        public int Idrol
        {
            get
            {
                return idrol;
            }

            set
            {
                idrol = value;
            }
        }
    }
}
