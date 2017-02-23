using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosMYSQL
{
    

    public class  EntityQueryBuild
    {
        private string NombreEntidad;
        private string ClaseEntidad;
        private object ObjetoEntidad;
        private object primary_key;
        private bool autoincrement;

        public EntityQueryBuild(object entidad) {

            ObjetoEntidad = entidad;
            ClaseEntidad = entidad.GetType().FullName;
            NombreEntidad = entidad.GetType().Name;
            getPrimaryKey();
        }

        private void getPrimaryKey()
        {
            //obtiene el miembro pk de la clase entidad
            FieldInfo fpk = ObjetoEntidad.GetType().GetField("PRIMARY_KEY", BindingFlags.Public);
            //obtiene el miembro autoincrement de la clase entidad
            FieldInfo fai = ObjetoEntidad.GetType().GetField("AUTOINCREMENT", BindingFlags.Public);

            //obtiene el valor del el miembro especificado
            primary_key = fpk.GetValue(ObjetoEntidad);
            autoincrement = (bool) fai.GetValue(ObjetoEntidad);
        }

        private string getFields()
        {
            string result = string.Empty;

            //obtener todos los miembros que representan las columnas de la entidad
            FieldInfo[] fields = ObjetoEntidad.GetType().GetFields(BindingFlags.Public);
            

            //recorrer array para crear string de nombres de columnas
            for(int i = 0; i < fields.Length; i++)
            {

                if (autoincrement && (fields[i].Name == primary_key.ToString()))
                {
                    //no incluimos la columna primary_key ya que es autoincrement
                }
                else{
                    result += fields[i].Name + ",";
                }
            }

            //quitamos la ultima coma ;
            result = result.Substring(0, fields.Length - 1);

            return result;
        }

        private string getAllFields()
        {
            string result = string.Empty;

            //obtener todos los miembros que representan las columnas de la entidad
            FieldInfo[] fields = ObjetoEntidad.GetType().GetFields(BindingFlags.Public);

            //recorrer array para crear string de nombres de columnas
            for (int i = 0; i < fields.Length; i++)
            {
                result += fields[i].Name + ",";
            }

            //quitamos la ultima coma ;
            result = result.Substring(0, fields.Length - 1);

            return result;
        }


    }

}
