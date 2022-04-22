using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public class Cache_Datos_Consultas
    {
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public string Motivo { get; set; }
        public string Fecha { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Presion_Arterial { get; set; }
        public Double Temperatura { get; set; }
    }
}
