using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{
    partial class Vuelos : Entidad
    {
        private int idvuelo;
        private int idorigen;
        private int iddestino;
        private DateTime fecha;
        private int estado;

        public Vuelos()
        {
            init();
        }

        public int Idvuelo { get => idvuelo; set => idvuelo = value; }
        public int Idorigen { get => idorigen; set => idorigen = value; }
        public int Iddestino { get => iddestino; set => iddestino = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Estado { get => Estado; set => Estado = value; }

        private void init()
        {
            PRIMARY_KEY = "Idvuelo";
            AUTOINCREMENT = false;
        }
    }
}
