using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_Usuarios: CD_ConexionFireBase
    {
        #region CRUD

        #region Crear

        #endregion

        #region Leer
        /// <summary>
        /// Listar Usuarios
        /// </summary>
        /// <returns>Retorna una lista con todos los usuarios registrados.</returns>
        public async Task<List<CM_Usuarios>> listausuarios()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("Usuarios")
                    .OrderByKey()
                    .OnceAsync<CM_Usuarios>())
                    .Select(datos => new CM_Usuarios
                    {
                        IdUsurioFireBase = datos.Key,
                        IdUsuario = datos.Object.IdUsuario,
                        NombreCompleto = datos.Object.NombreCompleto,
                        Email = datos.Object.Email,
                        Estado = datos.Object.Estado,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_Usuarios>();
            }
        }
        #endregion

        #region Actualizar

        #endregion

        #region Eliminar

        #endregion

        #endregion
    }
}
