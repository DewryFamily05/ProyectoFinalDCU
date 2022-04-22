using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class DatosConsultas : ConecionSQL
    {


        public void Llenar_IdPaciente(ComboBox IdPaciente)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "select idPaciente from Paciente;";
                using (var command = new SqlCommand(query, coneccion))
                {
                    SqlDataReader dr;
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        IdPaciente.Items.Add(dr["idPaciente"].ToString());
                    }
                }
              
                
            }
                
        }

        public void Llenar_IdMedico(ComboBox IdMedico)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "select IdMedico from Medico;";
                using (var command = new SqlCommand(query, coneccion))
                {
                    SqlDataReader dr;
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        IdMedico.Items.Add(dr["IdMedico"].ToString());
                    }
                }


            }

        }


        public DataTable Listar_Consultas()
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "select * from HistorialMedica ";
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

        public DataTable Buscar_Cosultas(string buscar)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                string query = "SELECT * FROM HistorialMedica  WHERE Motivo LIKE '" + buscar + "%' ";
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


        public int insertar_Nueva_Consulta(Cache_Datos_Consultas nuevaConsulta)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "insert into HistorialMedica values("+nuevaConsulta.IdPaciente+","+nuevaConsulta.IdMedico+"," +
                    "'"+ nuevaConsulta.Motivo+"','"+ nuevaConsulta.Fecha+"','"+ nuevaConsulta.Sintomas+"'," +
                    "'"+ nuevaConsulta.Diagnostico+"','"+ nuevaConsulta.Tratamiento+"','"+ nuevaConsulta.Presion_Arterial+"'" +
                    ", "+ nuevaConsulta.Temperatura+");";
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }



        }

        public int Modificar_Consulta(Cache_Datos_Consultas modificarConsulta)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "UPDATE HistorialMedica SET idPaciente = "+ modificarConsulta .IdPaciente+ ", idMedico = "+ modificarConsulta .IdMedico+ ", Motivo = '"+ modificarConsulta .Motivo+ "', " +
                    "Fecha = '"+modificarConsulta .Fecha+ "', Sintomas = '"+ modificarConsulta .Sintomas+ "', Diagnostico = '"+modificarConsulta.Diagnostico+"', " +
                    "Tratamiento = '"+ modificarConsulta.Tratamiento + "', PresionArterial= '"+ modificarConsulta.Presion_Arterial+ "',Temperatura = "+ modificarConsulta .Temperatura+"" +
                    " WHERE IdHistorial = "+ modificarConsulta.IdConsulta;
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }

        }



        public int Eliminar_Consulta(int id_Consulta)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                int retorno = 0;
                string query = "delete from HistorialMedica   where IdHistorial = "+id_Consulta;
                using (var command = new SqlCommand(query, coneccion))
                {
                    retorno = command.ExecuteNonQuery();
                    return retorno;
                }

            }



        }
    }
}
