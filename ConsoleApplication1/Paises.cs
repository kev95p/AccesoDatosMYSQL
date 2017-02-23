using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosMYSQL;

namespace ConsoleApplication1
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

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        private void init()
        {
            PRIMARY_KEY = "idpais";
            AUTOINCREMENT = true;
        }

    }
}
