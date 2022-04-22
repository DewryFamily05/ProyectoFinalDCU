using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public abstract class ConecionSQL
    {
        private readonly string string_Coneccion;

        public ConecionSQL()
        {
            string_Coneccion = "Server = DESKTOP-C65HCKQ; DataBase = MyHospital; integrated security = true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(string_Coneccion);
        }
    }
}
