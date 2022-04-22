using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using CapaComun.Cache;
using System.Windows.Forms;

namespace Dominio
{
    public class DominioConsulta
    {

        DatosConsultas datosConsultas = new DatosConsultas();

        public void Llenar_IdPaciente(ComboBox IdPaciente)
        {
            datosConsultas.Llenar_IdPaciente(IdPaciente);
        }

        public void Llenar_IdMedico(ComboBox IdMedico)
        {
            datosConsultas.Llenar_IdMedico(IdMedico);
        }

        public DataTable Listar_Consultas()
        {
            return datosConsultas.Listar_Consultas();
        }

        public DataTable Buscar_Consultas(string buscar)
        {
            return datosConsultas.Buscar_Cosultas(buscar);
        }

        public int insertar_Nueva_Consulta(Cache_Datos_Consultas nuevaCosulta)
        {
            return datosConsultas.insertar_Nueva_Consulta(nuevaCosulta);
        }


        public int Modificar_Paciente(Cache_Datos_Consultas modificarConsulta)
        {
            return datosConsultas.Modificar_Consulta(modificarConsulta);
        }



        public int Eliminar_Consulta(int id_Consulta)
        {
            return datosConsultas.Eliminar_Consulta(id_Consulta);
        }

    }
}
