using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{
    class Roles:Entidad
    {
        private int idrol;
        private string rol;
        public Roles()
        {

        }

        public int Idrol { get => idrol; set => idrol = value; }
        public string Rol { get => rol; set => rol = value; }

        private void init()
        {
            PRIMARY_KEY = "Idrol";
            AUTOINCREMENT = true;
        }
    }
}
