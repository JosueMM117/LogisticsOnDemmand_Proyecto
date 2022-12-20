using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace LogisticsOnDemmand_Proyecto.Capa_Negocio
{
    public class CN_Clientes: CD_Clientes
    {
        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns>Retorna una lista con todos los clientes registrados.</returns>
        public async Task<List<CM_Clientes>> Listar_Clientes() => await listaclientes();

        /// <summary>
        /// Registrar Clientes
        /// </summary>
        /// <param name="objcliente"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Clientes(CM_Clientes objcliente, out string Mensaje)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objcliente.NombreCompleto))
                    Mensaje += "No puede dejar el campo *Nombre Completo* en blanco.";
                else if (string.IsNullOrEmpty(objcliente.Telefono) && string.IsNullOrEmpty(objcliente.Telefono2))
                    Mensaje += "Debe indicar por lo menos un número de contacto.";
                else if (string.IsNullOrEmpty(objcliente.Direccion))
                    Mensaje += "Debe indicar la direccion del cliente.";
                if (Mensaje != string.Empty)
                    return false;
                else
                    return registrar_clientes(objcliente, out Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mensaje = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Actualizar Inforacion del Cliente
        /// </summary>
        /// <param name="objcliente"></param>
        /// <returns>Retorn True, si el registro fue actualizado correctamente.</returns>
        public async Task<bool> Actualizar_InformacionCliente(CM_Clientes objcliente) => await actualizar_informacionclientes(objcliente);

        /// <summary>
        /// Borrar Clientes
        /// </summary>
        /// <param name="objcliente"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> Borrar_Clientes(CM_Clientes objcliente)
        {
            try
            {
                //Si el cliente esta relacionado a una ruta, el misma no puede ser borrado.
                List<CM_DetalleRuta> ListaRutas = await new CD_Rutas().listadetallerutas();
                var validar_cliente = ListaRutas.Where(b => b.IdCliente == objcliente.IdCliente).FirstOrDefault();
                if (validar_cliente != null)
                {
                    MessageBox.Show("No se puede borrar el cliente, porque ya posee un historico de rutas.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    return await borrar_cliente(objcliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
