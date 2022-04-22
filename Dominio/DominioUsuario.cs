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
    public class DominioUsuario
    {
        DatosUsuario datoUser = new DatosUsuario();

        public bool LoginUser(string usuario, string pass)
        {
            return datoUser.Login(usuario, pass);
        }

        public DataTable Listar()
        {
            return datoUser.Listar();
        }

        public int insertar_Nuevo_Doctor(Cache_Datos_medico nuevoMedico)
        {
            return datoUser.insertar_Nuevo_Doctor(nuevoMedico);
        }

        public int Modificar_Doctor(Cache_Datos_medico Modificar_Medico)
        {
            return datoUser.Modificar_Doctor(Modificar_Medico);
        }

        public int Eliminar_Doctor(int idMedico)
        {
            return datoUser.Eliminar_Doctor(idMedico);
        }


        public DataTable Buscar(string buscar)
        {
            return datoUser.Buscar(buscar);
        }
    }
}
