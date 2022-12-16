using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LogisticsOnDemmand_Proyecto.Capa_Modelo
{
    public class CM_Clientes
    {
        public string IdClienteFireBase { get; set; }
        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string FechaRegistro { get; set; }
    }   
}
