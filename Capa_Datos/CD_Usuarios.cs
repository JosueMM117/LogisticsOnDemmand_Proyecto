using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database.Query;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using Firebase.Auth;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_Usuarios: CD_ConexionFireBase
    {
        #region CRUD

        #region Crear
        /// <summary>
        /// Registrar Usuarios
        /// </summary>
        /// <param name="objusuario"></param>
        /// <returns>Retorna True si el registro fue insertado correctamente, en caso contrario devuelve false.</returns>
        public bool registrar_usuarios(CM_Usuarios objusuario, out string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                FireBase_Connect
                    .Child("Usuarios")
                    .PostAsync(new CM_Usuarios()
                    {
                        IdUsuario = objusuario.IdUsuario,
                        NombreCompleto = objusuario.NombreCompleto,
                        Email = objusuario.Email,
                        Rol = objusuario.Rol,
                        Telefono = objusuario.Telefono,
                        Estado = objusuario.Estado,
                        FechaRegistro = objusuario.FechaRegistro
                    });
                mensaje = "Usuario registrado!";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensaje = string.Empty;
                return false;
            }
        }
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
                        Telefono = datos.Object.Telefono,
                        Rol = datos.Object.Rol,
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
        public async Task<bool> actualizar_informacionusuarios(CM_Usuarios objusuario)
        {
            try
            {
                var datos_usuario = (await FireBase_Connect
                    .Child("Usuarios")
                    .OnceAsync<CM_Usuarios>()).Where(b=>b.Object.IdUsuario == objusuario.IdUsuario).FirstOrDefault();
                await FireBase_Connect
                    .Child("Usuarios")
                    .Child(datos_usuario.Key)
                    .PutAsync(new CM_Usuarios()
                    {
                        IdUsuario = datos_usuario.Object.IdUsuario,
                        NombreCompleto = objusuario.NombreCompleto,
                        Email = datos_usuario.Object.Email,
                        Telefono = objusuario.Telefono,
                        Rol = objusuario.Rol,
                        Estado = objusuario.Estado,
                        FechaRegistro = datos_usuario.Object.FechaRegistro
                    });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eliminar

        #endregion

        #endregion
    }
}
