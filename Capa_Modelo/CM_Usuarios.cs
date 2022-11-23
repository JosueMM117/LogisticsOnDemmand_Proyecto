using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Modelo
{
    public class CM_Usuarios
    {
        public string IdUsurioFireBase { get; set; }
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
