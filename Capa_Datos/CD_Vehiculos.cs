using Firebase.Database.Query;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_Vehiculos: CD_ConexionFireBase
    {
        #region CRUD

        #region Crear
        /// <summary>
        /// Registrar Vehículos
        /// </summary>
        /// <param name="objvehiculo"></param>
        /// <param name="mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente, en caso contrario devuelve false.</returns>
        public bool registrar_vehiculos(CM_Vehiculos objvehiculo, out string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                FireBase_Connect
                    .Child("Vehiculos")
                    .PostAsync(new CM_Vehiculos()
                    {
                        IdVehiculo = objvehiculo.IdVehiculo,
                        NombreVehiculo = objvehiculo.NombreVehiculo,
                        CargaMaxima = objvehiculo.CargaMaxima,
                        CargaManima = objvehiculo.CargaManima,
                        Identificacion = objvehiculo.Identificacion,
                        HorarioDisponibilidad = objvehiculo.HorarioDisponibilidad,
                        Marca = objvehiculo.Marca,
                        Conductor = new CM_Usuarios
                        {
                            IdUsuario = objvehiculo.Conductor.IdUsuario,
                            NombreCompleto = objvehiculo.Conductor.NombreCompleto,
                        },
                        Habilidades = new CM_Habilidades
                        {
                            IdHabilidad = objvehiculo.Habilidades.IdHabilidad,
                            Descripcion = objvehiculo.Habilidades.Descripcion,
                        },
                        Estado = objvehiculo.Estado,
                        FechaRegistro = objvehiculo.FechaRegistro
                    });
                mensaje = "Vehículo registrado!.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensaje = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Registrar Habilidades
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <param name="mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente, en caso contrario devuelve false.</returns>
        public bool registrar_habilidades(CM_Habilidades objhabilidad, out string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                FireBase_Connect
                    .Child("Habilidades")
                    .PostAsync(new CM_Habilidades()
                    {
                        IdHabilidad = objhabilidad.IdHabilidad,
                        Descripcion = objhabilidad.Descripcion,
                        Estado = objhabilidad.Estado,
                        FechaRegistro = objhabilidad.FechaRegistro
                    });
                mensaje = "Habilidades registrado!.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensaje = string.Empty;
                return false;
            }
        }
        #endregion

        #region Leer
        /// <summary>
        /// Listar Vehículos
        /// </summary>
        /// <returns>Retorna una lista con todos los vehículos registrados.</returns>
        public async Task<List<CM_Vehiculos>> listavehiculos()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("Vehiculos")
                    .OrderByKey()
                    .OnceAsync<CM_Vehiculos>())
                    .Select(datos => new CM_Vehiculos
                    {
                        IdVehiculoFireBase = datos.Key,
                        IdVehiculo = datos.Object.IdVehiculo,
                        NombreVehiculo = datos.Object.NombreVehiculo,
                        CargaMaxima = datos.Object.CargaMaxima,
                        CargaManima = datos.Object.CargaManima,
                        Identificacion = datos.Object.Identificacion,
                        HorarioDisponibilidad = datos.Object.HorarioDisponibilidad,
                        Marca = datos.Object.Marca,
                        Conductor = new CM_Usuarios
                        {
                            IdUsuario = datos.Object.Conductor.IdUsuario,
                            NombreCompleto = datos.Object.Conductor.NombreCompleto,
                        },
                        Habilidades = new CM_Habilidades
                        {
                            IdHabilidad = datos.Object.Habilidades.IdHabilidad,
                            Descripcion = datos.Object.Habilidades.Descripcion,
                        },
                        Estado = datos.Object.Estado,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_Vehiculos>();
            }
        }

        /// <summary>
        /// Listar Habilidades
        /// </summary>
        /// <returns>Retorna una lista con todos los vehículos registrados.</returns>
        public async Task<List<CM_Habilidades>> listahabilidades()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("Habilidades")
                    .OrderByKey()
                    .OnceAsync<CM_Habilidades>())
                    .Select(datos => new CM_Habilidades
                    {
                        IdHabilidadFireBase = datos.Key,
                        IdHabilidad = datos.Object.IdHabilidad,
                        Descripcion = datos.Object.Descripcion,
                        Estado = datos.Object.Estado,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_Habilidades>();
            }
        }
        #endregion

        #region Actualizar
        /// <summary>
        /// Actualizar Vehículos
        /// </summary>
        /// <param name="objvehiculo"></param>
        /// <returns>Retorna True, si el registro fue actualizado correctamente, en caso contrario devuelve false.</returns>
        public async Task<bool> actualizar_informacionesvehiculos(CM_Vehiculos objvehiculo)
        {
            try
            {
                var datos_vehiculo = (await FireBase_Connect
                    .Child("Vehiculos")
                    .OnceAsync<CM_Vehiculos>()).Where(b => b.Object.IdVehiculo == objvehiculo.IdVehiculo).FirstOrDefault();

                await FireBase_Connect
                    .Child("Vehiculos")
                    .Child(datos_vehiculo.Key)
                    .PutAsync(new CM_Vehiculos()
                    {
                        IdVehiculo = datos_vehiculo.Object.IdVehiculo,
                        NombreVehiculo = objvehiculo.NombreVehiculo,
                        CargaMaxima = objvehiculo.CargaMaxima,
                        CargaManima = objvehiculo.CargaManima,
                        Identificacion = objvehiculo.Identificacion,
                        HorarioDisponibilidad = objvehiculo.HorarioDisponibilidad,
                        Marca = objvehiculo.Marca,
                        Conductor = new CM_Usuarios
                        {
                            IdUsuario = objvehiculo.Conductor.IdUsuario,
                            NombreCompleto = objvehiculo.Conductor.NombreCompleto,
                        },
                        Habilidades = new CM_Habilidades
                        {
                            IdHabilidad = objvehiculo.Habilidades.IdHabilidad,
                            Descripcion = objvehiculo.Habilidades.Descripcion,
                        },
                        Estado = objvehiculo.Estado,
                        FechaRegistro = datos_vehiculo.Object.FechaRegistro
                    });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Actualizar Habilidades
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <returns>Retorna True, si el registro fue actualizado correctamente, en caso contrario devuelve false.</returns>
        public async Task<bool> actualizar_informacioneshabilidades(CM_Habilidades objhabilidad)
        {
            try
            {
                var datos_habilidad = (await FireBase_Connect
                    .Child("Habilidades")
                    .OnceAsync<CM_Habilidades>()).Where(b => b.Object.IdHabilidad == objhabilidad.IdHabilidad).FirstOrDefault();

                await FireBase_Connect
                    .Child("Habilidades")
                    .Child(datos_habilidad.Key)
                    .PutAsync(new CM_Habilidades()
                    {
                        IdHabilidad = datos_habilidad.Object.IdHabilidad,
                        Descripcion = objhabilidad.Descripcion,
                        Estado = objhabilidad.Estado,
                        FechaRegistro = datos_habilidad.Object.FechaRegistro
                    });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Eliminar
        /// <summary>
        /// Borrar Vehículos
        /// </summary>
        /// <param name="objvehiculo"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> borrar_vehiculo(CM_Vehiculos objvehiculo)
        {
            try
            {
                var borrar = (await FireBase_Connect
                    .Child("Vehiculos")
                    .OnceAsync<CM_Vehiculos>()).Where(b => b.Object.IdVehiculo == objvehiculo.IdVehiculo).FirstOrDefault();
                await FireBase_Connect.Child("Vehiculos").Child(borrar.Key).DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Borrar Habilidades
        /// </summary>
        /// <param name="objhabilidad"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> borrar_habilidad(CM_Habilidades objhabilidad)
        {
            try
            {
                var borrar = (await FireBase_Connect
                    .Child("Habilidades")
                    .OnceAsync<CM_Habilidades>()).Where(b => b.Object.IdHabilidad == objhabilidad.IdHabilidad).FirstOrDefault();
                await FireBase_Connect.Child("Habilidades").Child(borrar.Key).DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #endregion
    }
}
