using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Negocio
{
    public class CN_Rutas: CD_Rutas
    {

        /// <summary>
        /// Listar Rutas
        /// </summary>
        /// <returns>Retorna una lista con todas las rutas registrados.</returns>
        public async Task<List<CM_Rutas>> Listar_Rutas() => await listarutas();

        /// <summary>
        /// Listar Detalle Rutas
        /// </summary>
        /// <returns>Retorna una lista con todos los detalles de rutas registrados.</returns>
        public async Task<List<CM_DetalleRuta>> Listar_DetalleRutas() => await listadetallerutas();

        /// <summary>
        /// Registrar Rutas
        /// </summary>
        /// <param name="objruta"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Rutas(CM_Rutas objruta, out string Mensaje, List<CM_DetalleRuta> detalleruta)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objruta.Titulo))
                    Mensaje += "Debe indicar el título de esta ruta.\n";
                else if (string.IsNullOrEmpty(objruta.Concepto))
                    Mensaje += "Debe indicar un concepto.\n";
                else if (objruta.Fecha_Entrega.Date > DateTime.Now)
                    Mensaje += "No puede crear una ruta con fecha futura.\n";
                else if (string.IsNullOrEmpty(objruta.Tiempo_Ruta))
                    Mensaje += "Es necesario indicar el tiempo que derará el vehículo en completar su ruta.\n";
                else if (string.IsNullOrEmpty(objruta.Prioridad))
                    Mensaje += "Debe indicar el nivel de prioridad que tendrá esta ruta\n";
                if (Mensaje != string.Empty)
                    return false;
                else
                    return registrar_rutas(objruta, out Mensaje, detalleruta); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mensaje = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Actualizar Inforacion de la ruta
        /// </summary>
        /// <param name="objruta"></param>
        /// <param name="detalleruta"></param>
        /// <returns>Retorn True, si el registro fue actualizado correctamente.</returns>
        public async Task<bool> Actualizar_InformacionRuta(CM_Rutas objruta, List<CM_DetalleRuta> detalleruta)
            => await actualizar_informacionruta(objruta, detalleruta);

        /// <summary>
        /// Borrar Rutas
        /// </summary>
        /// <param name="objruta"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> Borrar_Rutas(CM_Rutas objruta)
        {
            try
            {
                //Si una ruta esta en estado completada, la misma no puede ser borrada.
                List<CM_Rutas> ListaRutas = await listarutas();
                var validar_rutas = ListaRutas.Where(b=>b.IdRuta == objruta.IdRuta).FirstOrDefault();
                if (validar_rutas.Estado == "Completada")
                {
                    MessageBox.Show("No se puede borrar la ruta, porque se encuentra completada.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }  
                else
                    return await borrar_ruta(objruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
