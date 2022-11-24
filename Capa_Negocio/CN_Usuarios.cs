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

        public bool Registrar_Usuario(CM_Usuarios objusuario, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(objusuario.NombreCompleto))
            {
                Mensaje += "No se puede dejar el campo *Nombre Completo* en blanco.\n";
            }
            if (string.IsNullOrEmpty(objusuario.Email))
            {
                Mensaje += "No se puede dejar el campo de *E-mail* en blanco.\n";
            }
            if (string.IsNullOrEmpty(objusuario.Clave))
            {
                Mensaje += "Debe indicar una *Contraseña*\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
                return cdusuarios.registrar_usuarios(objusuario, out Mensaje);
        }
    }
}
