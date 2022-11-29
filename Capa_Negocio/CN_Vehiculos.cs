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
        private CD_Vehiculos cdvehiculos = new CD_Vehiculos();

        /// <summary>
        /// Listar Vehiculos
        /// </summary>
        /// <returns>Retorna una lista con todos los vehículos registrados.</returns>
        public async Task<List<CM_Vehiculos>> Listar_Vehículos()
        {
            return await cdvehiculos.listavehiculos();
        }

        /// <summary>
        /// Listar Habilidades
        /// </summary>
        /// <returns>Retorna una lista con todos los habilidades registrados.</returns>
        public async Task<List<CM_Habilidades>> Listar_Habilidades()
        {
            return await cdvehiculos.listahabilidades();
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
                {
                    Mensaje += "No se puede dejar el campo *Nombre* en blanco.\n";
                }
                if (string.IsNullOrEmpty(objvehiculo.Identificacion))
                {
                    Mensaje += "Es necesario indicar la identificacíon de este vehículo.\n";
                }
                if (objvehiculo.CargaMaxima == 0 || objvehiculo.CargaManima == 0)
                {
                    Mensaje += "Debe indicar la cantidad la cantidad mínima y máxima que soportará este vehículo.\n";
                }
                if (objvehiculo.Conductor.IdUsuario == 0 || string.IsNullOrEmpty(objvehiculo.Conductor.NombreCompleto))
                {
                    Mensaje += "No puede registrar un vehiculo sin indicar antes el conductor\n";
                }
                if (Mensaje != string.Empty)
                {
                    return false;
                }
                else
                    return cdvehiculos.registrar_vehiculos(objvehiculo, out Mensaje);
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
                {
                    Mensaje += "No se puede dejar el campo *Descripcion* en blanco.\n";
                }
                if (Mensaje != string.Empty)
                {
                    return false;
                }
                else
                    return cdvehiculos.registrar_habilidades(objhabilidad, out Mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return await cdvehiculos.actualizar_informacionesvehiculos(objvehiculo);
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
                return await cdvehiculos.actualizar_informacioneshabilidades(objhabilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //validar si el vehiculo que estamos borrando se encuentra relacionado a una ruta, de ser asi, no permita borrar el 
                //registro, solo se pueda inactivar.
                return await cdvehiculos.borrar_vehiculo(objvehiculo);
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
                //validar si la habilidad se encuentra ralacionada a un vehiculo.
                return await cdvehiculos.borrar_habilidad(objhabilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
