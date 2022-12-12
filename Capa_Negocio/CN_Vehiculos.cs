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
    public class CN_Vehiculos
    {
        private CD_Vehiculos cd_vehiculos = new CD_Vehiculos();
        private CD_Rutas cd_rutas = new CD_Rutas();

        /// <summary>
        /// Listar Vehiculos
        /// </summary>
        /// <returns>Retorna una lista con todos los vehículos registrados.</returns>
        public async Task<List<CM_Vehiculos>> Listar_Vehículos()
        {
            return await cd_vehiculos.listavehiculos();
        }

        /// <summary>
        /// Listar Habilidades
        /// </summary>
        /// <returns>Retorna una lista con todos los habilidades registrados.</returns>
        public async Task<List<CM_Habilidades>> Listar_Habilidades()
        {
            return await cd_vehiculos.listahabilidades();
        }

        /// <summary>
        /// Registrar Vehículos
        /// </summary>
        /// <param name="objvehiculo"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Vehiculo(CM_Vehiculos objvehiculo, out string Mensaje)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objvehiculo.NombreVehiculo))
                    Mensaje += "No se puede dejar el campo *Nombre* en blanco.\n";
                if (string.IsNullOrEmpty(objvehiculo.Identificacion))
                    Mensaje += "Es necesario indicar la identificacíon de este vehículo.\n";
                if (objvehiculo.CargaMaxima == 0 || objvehiculo.CargaMinima == 0)                
                    Mensaje += "Debe indicar la cantidad la cantidad mínima y máxima que soportará este vehículo.\n";                
                if (objvehiculo.HorarioDisponibilidad > 24)
                    Mensaje += "Las horas indicas sobrepasan las horas permitidas por dia.\nLa cantidad de horas disponibles por dia es 24 Horas.";
                if (objvehiculo.Conductor.IdUsuario == 0 || string.IsNullOrEmpty(objvehiculo.Conductor.NombreCompleto))
                    Mensaje += "No puede registrar un vehiculo sin indicar antes el conductor\n";
                if (Mensaje != string.Empty)
                    return false;
                else
                    return cd_vehiculos.registrar_vehiculos(objvehiculo, out Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Registrar Habilidades
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <param name="Mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente.</returns>
        public bool Registrar_Habilidad(CM_Habilidades objhabilidad, out string Mensaje)
        {
            try
            {
                Mensaje = string.Empty;
                if (string.IsNullOrEmpty(objhabilidad.Descripcion))
                    Mensaje += "No se puede dejar el campo *Descripcion* en blanco.\n";    
                if (Mensaje != string.Empty)
                    return false;
                else
                    return cd_vehiculos.registrar_habilidades(objhabilidad, out Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Actualizar Inforacion del Vehiculo
        /// </summary>
        /// <param name="objusuario"></param>
        /// <returns>Retorn True, si el registro fue actualizado correctamente.</returns>
        public async Task<bool> Actualizar_InformacionVehiculos(CM_Vehiculos objvehiculo)
        {
            try
            {
                return await cd_vehiculos.actualizar_informacionesvehiculos(objvehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Actualizar Inforacion de la Habilidad
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <returns>Retorn True, si el registro fue actualizado correctamente.</returns>
        public async Task<bool> Actualizar_InformacionHabilidades(CM_Habilidades objhabilidad)
        {
            try
            {
                return await cd_vehiculos.actualizar_informacioneshabilidades(objhabilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Borrar Vehículos
        /// </summary>
        /// <param name="objvehiculo"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> Borrar_Vehiculos(CM_Vehiculos objvehiculo)
        {
            try
            {
                //Si un vehiculo ya posee rutas cuyo estado sea completado, el mismo no puede ser borrado.
                List<CM_DetalleRuta> ListaRutas = await cd_rutas.listadetallerutas();
                var validar_rutas = ListaRutas.Where(b => b.IdVehiculo == objvehiculo.IdVehiculo).FirstOrDefault();
                if (validar_rutas != null)
                {
                    MessageBox.Show("No se puede borrar el vehículo porque ya posee histórico de rutas.", "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }  
                else
                    return await cd_vehiculos.borrar_vehiculo(objvehiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Borrar Habilidades
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> Borrar_Habilidades(CM_Habilidades objhabilidad)
        {
            try
            {
                //Si una habilidad se encuentra relacionada a un vehiculo, esta no puede ser borrada.
                List<CM_Vehiculos> BuscarDatos = await cd_vehiculos.listavehiculos();
                var validar_datos = BuscarDatos.Where(b => b.Habilidades.IdHabilidad == objhabilidad.IdHabilidad).FirstOrDefault();
                if (validar_datos != null)
                {
                    MessageBox.Show("No puede borrar esta habilidad porque esta relacionada a un vehículo.", "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    return await cd_vehiculos.borrar_habilidad(objhabilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
