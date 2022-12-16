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

        #endregion

        #region Actualizar

        #endregion

        #region Eliminar

        #endregion

        #endregion
    }
}
