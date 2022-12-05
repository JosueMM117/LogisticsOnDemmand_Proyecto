using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Negocio
{
    public class CN_Rutas
    {
        private CD_Rutas cdrutas = new CD_Rutas();

        /// <summary>
        /// Listar Rutas
        /// </summary>
        /// <returns>Retorna una lista con todas las rutas registrados.</returns>
        public async Task<List<CM_Rutas>> Listar_Rutas()
        {
            return await cdrutas.listarutas();
        }
    }
}
