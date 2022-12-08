using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Modelo
{
    public class CM_DetalleRuta
    {
        public string IdDetalleRutaFireBase { get;set; }
        public int IdDetalleRuta { get; set; }
        public int IdRuta { get; set; }
        public int IdVehiculo { get; set; }
        public string NombreVehiculo { get; set; }
        public string Conductor { get; set; }
        public string DireccionEnvio { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente1 { get; set; }
        public string TelefonoCliente2 { get; set; }
        public string EmailCliente { get; set; }
        public string FechaRegistro { get; set; }
    }
}
