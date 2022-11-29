using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace LogisticsOnDemmand_Proyecto.Capa_Modelo
{
    public class CM_Vehiculos
    {
        public string IdVehiculoFireBase { get; set; }
        public int IdVehiculo { get; set; }
        public string NombreVehiculo { get; set; }
        public string Marca { get; set; }
        public decimal CargaMaxima { get; set; }
        public decimal CargaManima { get; set; }
        public string Identificacion { get; set; }
        public int HorarioDisponibilidad { get; set; }
        public CM_Usuarios Conductor { get; set; }
        public CM_Habilidades Habilidades { get; set; }
        public string Estado { get;set; }
        public DateTime FechaRegistro { get; set; }
    }
}
