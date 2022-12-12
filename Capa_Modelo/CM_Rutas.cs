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
        public DateTime Fecha_Entrega { get; set; }
        public string Tiempo_Ruta { get; set; }
        public int Cargas { get; set; }
        //public List<CM_DetalleRuta> DetalleRuta { get; set; }
        public string Comentarios { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
