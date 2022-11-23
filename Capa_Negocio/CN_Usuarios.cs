using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOnDemmand_Proyecto.Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cdusuarios = new CD_Usuarios();
        public async Task<List<CM_Usuarios>> Listar_Usuarios()
        {
            return await cdusuarios.listausuarios();
        }
    }
}
