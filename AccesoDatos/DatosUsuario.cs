using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;

namespace AccesoDatos
{
    public class DatosUsuario:ConecionSQL
    {
        public bool Login(string usuario, string contra)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = coneccion;
                    command.CommandText = "select * from Usuarios where LogiName = @usuario and Password = @pass ;";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@pass", contra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) { 
                        Cache_de_Inicio_de_sesion.IdUsuario = reader.GetInt32(0);
                        Cache_de_Inicio_de_sesion.Nombre = reader.GetString(3);
                        Cache_de_Inicio_de_sesion.Apellido = reader.GetString(4);
                        Cache_de_Inicio_de_sesion.Posision = reader.GetString(5);
                        Cache_de_Inicio_de_sesion.Imail = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable Listar()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "select * from Medico";
                using (var command = new SqlCommand(query, coneccion))
                {
                    SqlDataAdapter adactador = new SqlDataAdapter();
                    adactador.SelectCommand = command;
                    DataTable tabla = new DataTable();
                    adactador.Fill(tabla);
                    return tabla;
                }
               
            }
           
        }

        public int insertar_Nuevo_Doctor(Cache_Datos_medico nuevoMedico)
        {
            using(var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "insert into Medico values('"+nuevoMedico.Nombre_del_Medico+"','"+nuevoMedico.Apellido_del_Medico+"" +
                    "','"+nuevoMedico.Cedula_del_Medico+"','"+nuevoMedico.Especialidad_del_Medico+"','"+nuevoMedico.Telefono_del_Medico+"" +
                    "','"+nuevoMedico.Correo_del_Medico+"','"+nuevoMedico.Estado_del_Medico+"')";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }
                   
            }
           


        }

        public int Modificar_Doctor(Cache_Datos_medico modificar_Medico)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "UPDATE Medico SET Nombre = '"+modificar_Medico.Nombre_del_Medico+"', Apellidos = '"+modificar_Medico.Apellido_del_Medico+"" +
                    "', Cedula = '"+modificar_Medico.Cedula_del_Medico+"', Especialidad = '"+modificar_Medico.Especialidad_del_Medico+"', Telefono = '"+modificar_Medico.Telefono_del_Medico+"" +
                    "', Carreo = '"+modificar_Medico.Correo_del_Medico+"', Estado = '"+modificar_Medico.Estado_del_Medico+"' WHERE IdMedico = "+modificar_Medico.IdMedico+"";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }

        }

        public int Eliminar_Doctor(int id_medico)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "delete from Medico  where IdMedico = "+id_medico+"";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }



        }

        public DataTable Buscar(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "SELECT * FROM Medico WHERE Nombre LIKE '"+buscar+"%' OR Apellidos LIKE '"+buscar+"%'";
                using (var command = new SqlCommand(query, coneccion))
                {
                    SqlDataAdapter adactador = new SqlDataAdapter();
                    adactador.SelectCommand = command;
                    DataTable tabla = new DataTable();
                    adactador.Fill(tabla);
                    return tabla;
                }

            }

        }


    }
}
