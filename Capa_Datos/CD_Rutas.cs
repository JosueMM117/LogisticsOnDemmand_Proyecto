using Firebase.Database.Query;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Datos
{
    public class CD_Rutas: CD_ConexionFireBase
    {
        #region CRUD

        #region Crear

        #endregion

        #region Leer
        /// <summary>
        /// Listar Rutas
        /// </summary>
        /// <returns>Retorna una lista con todas las rutas registrados.</returns>
        public async Task<List<CM_Rutas>> listarutas()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("Rutas")
                    .OrderByKey()
                    .OnceAsync<CM_Rutas>())
                    .Select(datos => new CM_Rutas
                    {
                        IdRutaFireBase = datos.Key,
                        IdRuta = datos.Object.IdRuta,
                        Titulo = datos.Object.Titulo,
                        Concepto = datos.Object.Concepto,
                        Direccion = datos.Object.Direccion,
                        Fecha_Entrega = datos.Object.Fecha_Entrega,
                        Ventana_Tiempo_Desde = datos.Object.Ventana_Tiempo_Desde,
                        Ventana_Tiempo_Hasta = datos.Object.Ventana_Tiempo_Hasta,
                        Cargas = datos.Object.Cargas,
                        Prioridad = datos.Object.Prioridad,
                        Comentarios = datos.Object.Comentarios,
                        Nombre_Cliente = datos.Object.Nombre_Cliente,
                        Telefono_Cliente = datos.Object.Telefono_Cliente,
                        Telefono2_Cliente = datos.Object.Telefono2_Cliente,
                        Email_Cliente = datos.Object.Email_Cliente,
                        DetalleRuta = new CM_DetalleRuta
                        {
                            IdDetalleRuta = datos.Object.DetalleRuta.IdDetalleRuta,
                            Destino1_Ruta = datos.Object.DetalleRuta.Destino1_Ruta,
                            Destino2_Ruta = datos.Object.DetalleRuta.Destino2_Ruta,
                        },
                        Vehiculo = new CM_Vehiculos
                        {
                            IdVehiculo = datos.Object.Vehiculo.IdVehiculo,
                            NombreVehiculo = datos.Object.Vehiculo.NombreVehiculo,
                            Conductor = new CM_Usuarios
                            {
                                IdUsuario = datos.Object.Vehiculo.Conductor.IdUsuario,
                                NombreCompleto = datos.Object.Vehiculo.Conductor.NombreCompleto
                            },
                            Habilidades = new CM_Habilidades
                            {
                                IdHabilidad = datos.Object.Vehiculo.Habilidades.IdHabilidad,
                                Descripcion = datos.Object.Vehiculo.Habilidades.Descripcion
                            }
                        },
                        Estado = datos.Object.Estado,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_Rutas>();
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
