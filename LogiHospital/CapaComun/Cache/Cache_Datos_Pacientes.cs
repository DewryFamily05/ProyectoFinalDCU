using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public class Cache_Datos_Pacientes
    {
        public int IdPaciente { get; set; }
        public string Nombre_del_Paciente { get; set; }
        public string Apellido_del_Paciente { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Correo_del_Paciente { get; set; }
        public string Telefono_del_Paciente { get; set; }
        public string Contacto_Emergencia { get; set; }
    }
}
