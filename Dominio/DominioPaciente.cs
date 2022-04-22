using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using CapaComun.Cache;

namespace Dominio
{
    public class DominioPaciente
    {
        DatosPacientes datosPacientes = new DatosPacientes();


        public DataTable Listar_Pacientes()
        {
            return datosPacientes.Listar_Paciente();
        }

        public DataTable Buscar_Pacientes(string buscar)
        {
            return datosPacientes.Buscar_Pacientes(buscar);
        }

       public int insertar_Nuevo_Paciente(Cache_Datos_Pacientes nuevoPaciente)
        {
            return datosPacientes.insertar_Nuevo_Paciente(nuevoPaciente);
        }

        public int Modificar_Paciente(Cache_Datos_Pacientes Modificar_Paciente)
        {
            return datosPacientes.Modificar_Paciente(Modificar_Paciente);
        }

        public int Eliminar_Paciente(int idPaciente)
        {
            return datosPacientes.Eliminar_Paciente(idPaciente);
        }
    }
}
