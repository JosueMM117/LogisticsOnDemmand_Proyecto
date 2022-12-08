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
        /// <summary>
        /// Registrar Rutas
        /// </summary>
        /// <param name="objruta"></param>
        /// <param name="mensaje"></param>
        /// <returns>Retorna True, si el registro fue insertado correctamente, en caso contrario devuelve false.</returns>
        public bool registrar_rutas(CM_Rutas objruta, out string mensaje)
        {
            try
            {
                mensaje = string.Empty;
                FireBase_Connect
                    .Child("Rutas")
                    .PostAsync(new CM_Rutas()
                    {
                        IdRuta = objruta.IdRuta,
                        Titulo = objruta.Titulo,
                        Concepto = objruta.Concepto,
                        Fecha_Entrega = objruta.Fecha_Entrega,
                        Tiempo_Ruta = objruta.Tiempo_Ruta,
                        Cargas = objruta.Cargas,
                        Comentarios = objruta.Comentarios,
                        Prioridad = objruta.Prioridad,
                        Estado = objruta.Estado,
                        FechaRegistro = objruta.FechaRegistro,
                        DetalleRuta = new CM_DetalleRuta
                        {
                            IdDetalleRuta = objruta.DetalleRuta.IdDetalleRuta,
                            IdRuta = objruta.DetalleRuta.IdRuta,
                            IdVehiculo = objruta.DetalleRuta.IdVehiculo,
                            NombreVehiculo = objruta.DetalleRuta.NombreVehiculo,
                            Conductor = objruta.DetalleRuta.Conductor,
                            DireccionEnvio = objruta.DetalleRuta.DireccionEnvio,
                            Latitud = objruta.DetalleRuta.Latitud,
                            Longitud = objruta.DetalleRuta.Longitud,
                            NombreCliente = objruta.DetalleRuta.NombreCliente,
                            TelefonoCliente1 = objruta.DetalleRuta.TelefonoCliente1,
                            TelefonoCliente2 = objruta.DetalleRuta.TelefonoCliente2,
                            EmailCliente = objruta.DetalleRuta.EmailCliente,
                            FechaRegistro = objruta.DetalleRuta.FechaRegistro
                        }
                    });
                mensaje = "Ruta registrada!.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensaje = string.Empty;
                return false;
            }
        }
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
                        Fecha_Entrega = datos.Object.Fecha_Entrega,
                        Tiempo_Ruta = datos.Object.Tiempo_Ruta,
                        Cargas = datos.Object.Cargas,
                        Prioridad = datos.Object.Prioridad,
                        Comentarios = datos.Object.Comentarios,
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

        /// <summary>
        /// Lista Detalle Rutas
        /// </summary>
        /// <returns>Retorna una lista con el detalle de todas las rutas.</returns>
        public async Task<List<CM_DetalleRuta>> listadetallerutas(int idruta)
        {
            try
            {
                return (await FireBase_Connect
                    .Child("DetalleRutas")
                    .OrderByKey()
                    .OnceAsync<CM_DetalleRuta>())
                    .Where(b=>b.Object.IdRuta == idruta)
                    .Select(datos => new CM_DetalleRuta
                    {
                        IdDetalleRuta = datos.Object.IdDetalleRuta,
                        IdRuta = datos.Object.IdRuta,
                        IdVehiculo = datos.Object.IdVehiculo,
                        NombreVehiculo = datos.Object.NombreVehiculo,
                        Conductor = datos.Object.Conductor,
                        DireccionEnvio = datos.Object.DireccionEnvio,
                        Latitud = datos.Object.Latitud,
                        Longitud = datos.Object.Longitud,
                        NombreCliente = datos.Object.NombreCliente,
                        TelefonoCliente1 = datos.Object.TelefonoCliente1,
                        TelefonoCliente2 = datos.Object.TelefonoCliente2,
                        EmailCliente = datos.Object.EmailCliente,
                        FechaRegistro = datos.Object.FechaRegistro
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CM_DetalleRuta>();
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
