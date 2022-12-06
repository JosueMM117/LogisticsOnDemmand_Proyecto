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

        /// <summary>
        /// Registrar Rutas
        /// </summary>
        /// <param name="objruta"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Rutas(CM_Rutas objruta, out string Mensaje)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objruta.Titulo))
                {
                    Mensaje += "No se puede dejar el campo *Titulo* en blanco.\n";
                }
                if (string.IsNullOrEmpty(objruta.Direccion))
                {
                    Mensaje += "Es necesario indicar la *Direccion* de destino.\n";
                }
                //if (objvehiculo.CargaMaxima == 0 || objvehiculo.CargaMinima == 0)
                //{
                //    Mensaje += "Debe indicar la cantidad la cantidad mínima y máxima que soportará este vehículo.\n";
                //}
                //if (objvehiculo.HorarioDisponibilidad > 24)
                //{
                //    Mensaje += "Las horas indicas sobrepasan las horas permitidas por dia.\nLa cantidad de horas disponibles por dia es 24 Horas.";
                //}
                //if (objvehiculo.Conductor.IdUsuario == 0 || string.IsNullOrEmpty(objvehiculo.Conductor.NombreCompleto))
                //{
                //    Mensaje += "No puede registrar un vehiculo sin indicar antes el conductor\n";
                //}
                if (Mensaje != string.Empty)
                {
                    return false;
                }
                else
                    return cdrutas.registrar_rutas(objruta, out Mensaje);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Mensaje = string.Empty;
                return false;
                throw;
            }
        }
    }
}
