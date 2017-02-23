using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosMYSQL
{
    public abstract class Entidad
    {
        public bool autoincrement = false;
        public string primary_key = "id";
    }
}
