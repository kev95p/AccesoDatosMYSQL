using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{
    class Reservaciones : Entidad
    {
        private int idreservacion;
        private string idusuario;
        private int idvuelo;
        private int nboletos;

        public Reservaciones()
        {

        }

        public int Idreservacion { get => idreservacion; set => idreservacion = value; }
        public string Idusuario { get => idusuario; set => idusuario = value; }
        public int Idvuelo { get => idvuelo; set => idvuelo = value; }
        public int Nboletos { get => nboletos; set => nboletos = value; }

        private void init()
        {
            PRIMARY_KEY = "Idreservacion";
            AUTOINCREMENT = true;
        }
    }
}
