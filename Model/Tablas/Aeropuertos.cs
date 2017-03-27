using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{
    class Aeropuertos : Entidad
    {
        private int idaeropuerto;
        private string aeropuerto;
        private int  idpais;
        private string ciudad;

        public Aeropuertos()
        {
            init();
        }

        public int Idaeropuerto { get => idaeropuerto; set => idaeropuerto = value; }
        public string Aeropuerto { get => aeropuerto; set => aeropuerto = value; }
        public int Idpais { get => idpais; set => idpais = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        private void init()
        {
            PRIMARY_KEY = "Idaeropuerto";
            AUTOINCREMENT = true;
        }
    }
}
