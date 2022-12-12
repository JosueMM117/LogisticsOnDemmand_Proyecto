using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cdusuarios = new CD_Usuarios();

        /// <summary>
        /// Listar Usuarios
        /// </summary>
        /// <returns>Retorna una lista con todos los usuarios registrados.</returns>
        public async Task<List<CM_Usuarios>> Listar_Usuarios()
        {
            return await cdusuarios.listausuarios();
        }

        /// <summary>
        /// Registrar Usuarios
        /// </summary>
        /// <param name="objusuario"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Usuario(CM_Usuarios objusuario, out string Mensaje)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objusuario.NombreCompleto))
                    Mensaje += "No se puede dejar el campo *Nombre Completo* en blanco.\n";
                else if (string.IsNullOrEmpty(objusuario.Email))
                    Mensaje += "No se puede dejar el campo de *E-mail* en blanco.\n";
                else if (string.IsNullOrEmpty(objusuario.Clave))
                    Mensaje += "Debe indicar una *Contraseña*\n";
                if (Mensaje != string.Empty)
                    return false;
                else
                    return cdusuarios.registrar_usuarios(objusuario, out Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Actualizar información del Usuario
        /// </summary>
        /// <param name="objusuario"></param>
        /// <returns>Retorn True, si el registro fue actualizado correctamente.</returns>
        public async Task<bool> Actualizar_InformacionUsuarios(CM_Usuarios objusuario)
        {
            try
            {
                return await cdusuarios.actualizar_informacionusuarios(objusuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
