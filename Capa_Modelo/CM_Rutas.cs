using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Modelo
{
    public class CM_Rutas
    {
        public string IdRutaFireBase { get; set; }
        public int IdRuta { get; set; }
        public string Titulo { get; set; }
        public string Concepto { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string Ventana_Tiempo_Desde { get; set; }
        public string Ventana_Tiempo_Hasta { get; set; }
        public int Cargas { get; set; }
        public CM_DetalleRuta DetalleRuta { get; set; }
        public CM_Vehiculos Vehiculo { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Telefono_Cliente { get; set; }
        public string Telefono2_Cliente { get; set; }
        public string Email_Cliente { get; set; }
        public string Comentarios { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
