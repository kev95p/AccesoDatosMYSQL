using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas 
{
    class Aviones : Entidad
    {

        private int idavion;
        private int capacidad;
        private string descripcion;

        public Aviones()
        {

        }

        public int Idavion { get => idavion; set => idavion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private void init()
        {
            PRIMARY_KEY = "Idavion";
            AUTOINCREMENT = true;
        }
    }


}
