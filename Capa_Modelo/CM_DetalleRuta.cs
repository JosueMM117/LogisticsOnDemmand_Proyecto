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
        public string Destino1_Ruta { get; set; }
        public string Destino2_Ruta { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
