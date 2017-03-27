using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Tablas
{
    
    public class Paises : Entidad
    {

        private int idpais;
        private string pais;

        public Paises()
        {
            init();
        }

        public Paises(string pais)
        {
            init();
            this.Pais = pais; 
        }

        public int Idpais { get => idpais; set => idpais = value; }
        public string Pais { get => pais; set => pais = value; }

        private void init()
        {
            PRIMARY_KEY = "Idpais";
            AUTOINCREMENT = true;
        }

    }
}
