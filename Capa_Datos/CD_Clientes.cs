using Firebase.Database.Query;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_Clientes:CD_ConexionFireBase
    {
        #region CRUD

        #region Crear
        /// <summary>
        /// Registrar Clientes
        /// </summary>
        /// <param name="objcliente"></param>
        /// <param name="mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente, en caso contrario devuelve false.</returns>
        public bool registrar_clientes(CM_Clientes objcliente,out string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                FireBase_Connect
                    .Child("Clientes")
                    .PostAsync(new CM_Clientes()
                    {
                        IdCliente = objcliente.IdCliente,
                        NombreCompleto = objcliente.NombreCompleto,
                        Email = objcliente.Email,
                        Telefono = objcliente.Telefono,
                        Telefono2 = objcliente.Telefono2,
                        Direccion = objcliente.Direccion,
                        Estado = objcliente.Estado,
                        FechaRegistro = objcliente.FechaRegistro
                    });
                mensaje = "Cliente registrada!.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensaje = string.Empty;
                return false;
            }
        }
        #endregion

        #region Leer
        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns>Retorna una lista con todas las rutas registrados.</returns>
        public async Task<List<CM_Clientes>> listaclientes()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("Clientes")
                    .OrderByKey()
                    .OnceAsync<CM_Clientes>())
                    .Select(datos => new CM_Clientes
                    {
                        IdClienteFireBase = datos.Key,
                        IdCliente = datos.Object.IdCliente,
                        NombreCompleto = datos.Object.NombreCompleto,
                        Email = datos.Object.Email,
                        Telefono = datos.Object.Telefono,
                        Telefono2 = datos.Object.Telefono2,
                        Direccion = datos.Object.Direccion,
                        Estado = datos.Object.Estado,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_Clientes>();
            }
        }
        #endregion

        #region Actualizar
        /// <summary>
        /// Actualzar Datos de Cliente
        /// </summary>
        /// <param name="objcliente"></param>
        /// <returns>Retorna True, si el registro fue actualizado correctamente, en caso contrario devuelve false.</returns>
        public async Task<bool> actualizar_informacionclientes(CM_Clientes objcliente)
        {
            try
            {
                var datos_cliente = (await FireBase_Connect
                    .Child("Clientes")
                    .OnceAsync<CM_Clientes>()).Where(b => b.Object.IdCliente == objcliente.IdCliente).FirstOrDefault();

                await FireBase_Connect
                    .Child("Clientes")
                    .Child(datos_cliente.Key)
                    .PutAsync(new CM_Clientes()
                    {
                        IdCliente = datos_cliente.Object.IdCliente,
                        NombreCompleto = objcliente.NombreCompleto,
                        Email = objcliente.Email,
                        Telefono = objcliente.Telefono,
                        Telefono2 = objcliente.Telefono2,
                        Direccion = objcliente.Direccion,
                        Estado = objcliente.Estado,
                        FechaRegistro = datos_cliente.Object.FechaRegistro
                    });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eliminar
        /// <summary>
        /// Borrar Cliente
        /// </summary>
        /// <param name="objcliente"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> borrar_cliente(CM_Clientes objcliente)
        {
            try
            {
                var borrar = (await FireBase_Connect
                    .Child("Clientes")
                    .OnceAsync<CM_Clientes>()).Where(b => b.Object.IdCliente == objcliente.IdCliente).FirstOrDefault();
                await FireBase_Connect.Child("Clientes").Child(borrar.Key).DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion
    }
}
