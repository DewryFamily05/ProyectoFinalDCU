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
    public class DatosPacientes : ConecionSQL
    {
        public DataTable Listar_Paciente()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "select * from Paciente;";
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

        public DataTable Buscar_Pacientes(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "SELECT * FROM Paciente WHERE Nombres LIKE '" + buscar + "%' OR Apellidos LIKE '" + buscar + "%'";
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

        public int insertar_Nuevo_Paciente(Cache_Datos_Pacientes nuevoPaciente)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "insert into Paciente values('"+nuevoPaciente.Nombre_del_Paciente+"','"+nuevoPaciente.Apellido_del_Paciente+"" +
                    "','"+nuevoPaciente.Fecha_Nacimiento+"','"+nuevoPaciente.Tipo_Sangre+"','"+nuevoPaciente.Correo_del_Paciente+"" +
                    "','"+nuevoPaciente.Telefono_del_Paciente+"','"+nuevoPaciente.Contacto_Emergencia+"')";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }



        }

        public int Modificar_Paciente(Cache_Datos_Pacientes modificar_Paciente)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "UPDATE Paciente SET Nombres = '"+modificar_Paciente.Nombre_del_Paciente+"', Apellidos = '"+modificar_Paciente.Apellido_del_Paciente+"'," +
                    " FechaNacimiento = '"+modificar_Paciente.Fecha_Nacimiento+"', TipoSangre = '"+modificar_Paciente.Tipo_Sangre+"', " +
                    " Correo = '"+modificar_Paciente.Correo_del_Paciente+"', Telefono = '"+modificar_Paciente.Telefono_del_Paciente+"', " +
                    " ContactoEmergencia = '"+modificar_Paciente.Contacto_Emergencia+"' WHERE idPaciente = "+modificar_Paciente.IdPaciente+"";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }

        }

        public int Eliminar_Paciente(int id_Paciente)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "delete from Paciente  where idPaciente = "+id_Paciente;
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }



        }

    
    }
}
