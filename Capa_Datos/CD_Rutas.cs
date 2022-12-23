using Firebase.Database.Query;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FireSharp.Response;
//using FireSharp.Interfaces;
//using FireSharp.Config;
using System.Windows.Controls;

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
        public bool registrar_rutas(CM_Rutas objruta, out string mensaje, List<CM_DetalleRuta> detalleruta)
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
                    });

                foreach (var items in detalleruta)
                {
                    FireBase_Connect
                    .Child("DetalleRutas/Registros")
                    .PostAsync(new CM_DetalleRuta()
                    {
                        IdDetalleRuta = items.IdDetalleRuta,
                        IdRuta = items.IdRuta,
                        IdVehiculo = items.IdVehiculo,
                        NombreVehiculo = items.NombreVehiculo,
                        Conductor = items.Conductor,
                        DireccionEnvio = items.DireccionEnvio,
                        Latitud = items.Latitud,
                        Longitud = items.Longitud,
                        NombreCliente = items.NombreCliente,
                        TelefonoCliente1 = items.TelefonoCliente1,
                        TelefonoCliente2 = items.TelefonoCliente2,
                        EmailCliente = items.EmailCliente,
                        FechaRegistro = items.FechaRegistro
                    });
                }
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
        public async Task<List<CM_DetalleRuta>> listadetallerutas()
        {
            try
            {
                return (await FireBase_Connect
                    .Child("DetalleRutas/Registros")
                    .OrderByKey()
                    .OnceAsync<CM_DetalleRuta>())
                    //.Where(b=>b.Object.IdRuta == idruta)
                    .Select(datos => new CM_DetalleRuta
                    {
                        IdDetalleRutaFireBase = datos.Key,
                        IdDetalleRuta = datos.Object.IdDetalleRuta,
                        IdRuta = datos.Object.IdRuta,
                        IdVehiculo = datos.Object.IdVehiculo,
                        NombreVehiculo = datos.Object.NombreVehiculo,
                        Conductor = datos.Object.Conductor,
                        DireccionEnvio = datos.Object.DireccionEnvio,
                        Latitud = datos.Object.Latitud,
                        Longitud = datos.Object.Longitud,
                        IdCliente = datos.Object.IdCliente,
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
        /// <summary>
        /// Actualzar Datos de Ruta
        /// </summary>
        /// <param name="objruta"></param>
        /// <param name="detalle_ruta"></param>
        /// <returns>Retorna True, si el registro fue actualizado correctamente, en caso contrario devuelve false.</returns>
        public async Task<bool> actualizar_informacionruta(CM_Rutas objruta, List<CM_DetalleRuta> detalle_ruta)
        {
            try
            {
                var datos_ruta = (await FireBase_Connect
                    .Child("Rutas")
                    .OnceAsync<CM_Rutas>()).Where(b => b.Object.IdRuta == objruta.IdRuta).FirstOrDefault();

                await FireBase_Connect
                    .Child("Rutas")
                    .Child(datos_ruta.Key)
                    .PutAsync(new CM_Rutas()
                    {
                        IdRuta = datos_ruta.Object.IdRuta,
                        Titulo = objruta.Titulo,
                        Concepto = objruta.Concepto,
                        Fecha_Entrega = objruta.Fecha_Entrega,
                        Tiempo_Ruta = objruta.Tiempo_Ruta,
                        Cargas = objruta.Cargas,
                        Comentarios = objruta.Comentarios,
                        Prioridad = objruta.Prioridad,
                        Estado = objruta.Estado,
                        FechaRegistro = datos_ruta.Object.FechaRegistro
                    });

                //Eliminar el detalle de la ruta
                List<CM_DetalleRuta> listardetalles = await listadetallerutas();
                var obteneriddetalle = listardetalles.Where(b=>b.IdRuta == objruta.IdRuta).ToList();
                foreach (var items in obteneriddetalle)
                {
                    await FireBase_Connect.Child("DetalleRutas/Registros").Child(items.IdDetalleRutaFireBase).DeleteAsync();
                }

                //Volvemos a insertar el detalle modificado
                foreach (var items in detalle_ruta)
                {
                    await FireBase_Connect
                        .Child("DetalleRutas/Registros")
                        .PostAsync(new CM_DetalleRuta()
                        {
                            IdDetalleRuta = items.IdDetalleRuta,
                            IdRuta = items.IdRuta,
                            IdVehiculo = items.IdVehiculo,
                            NombreVehiculo = items.NombreVehiculo,
                            Conductor = items.Conductor,
                            DireccionEnvio = items.DireccionEnvio,
                            Latitud = items.Latitud,
                            Longitud = items.Longitud,
                            IdCliente = items.IdCliente,
                            NombreCliente = items.NombreCliente,
                            TelefonoCliente1 = items.TelefonoCliente1,
                            TelefonoCliente2 = items.TelefonoCliente2,
                            EmailCliente = items.EmailCliente,
                            FechaRegistro = items.FechaRegistro
                        });
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Procesar Ruta
        /// </summary>
        /// <param name="objruta"></param>
        /// <returns>Retorna True, si el registro fue procesado correctamente, en caso contrario devuelve false.</returns>
        public async Task<bool> procesar_ruta(CM_Rutas objruta)
        {
            try
            {
                var datos_ruta = (await FireBase_Connect
                    .Child("Rutas")
                    .OnceAsync<CM_Rutas>()).Where(b => b.Object.IdRuta == objruta.IdRuta).FirstOrDefault();

                await FireBase_Connect
                   .Child("Rutas")
                   .Child(datos_ruta.Key)
                   .PutAsync(new CM_Rutas()
                   {
                       IdRuta = datos_ruta.Object.IdRuta,
                       Titulo = datos_ruta.Object.Titulo,
                       Concepto = datos_ruta.Object.Concepto,
                       Fecha_Entrega = datos_ruta.Object.Fecha_Entrega,
                       Tiempo_Ruta = datos_ruta.Object.Tiempo_Ruta,
                       Cargas = datos_ruta.Object.Cargas,
                       Comentarios = datos_ruta.Object.Comentarios,
                       Prioridad = datos_ruta.Object.Prioridad,
                       Estado = objruta.Estado,
                       FechaRegistro = datos_ruta.Object.FechaRegistro
                   });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eliminar
        /// <summary>
        /// Borrar Rutas
        /// </summary>
        /// <param name="objruta"></param>
        /// <returns>Retorna True, si el registro fue borrado correctamente.</returns>
        public async Task<bool> borrar_ruta(CM_Rutas objruta)
        {
            try
            {
                var borrar = (await FireBase_Connect
                    .Child("Rutas")
                    .OnceAsync<CM_Rutas>()).Where(b => b.Object.IdRuta == objruta.IdRuta).FirstOrDefault();
                await FireBase_Connect.Child("Rutas").Child(borrar.Key).DeleteAsync();

                //Eliminar el detalle de la ruta
                List<CM_DetalleRuta> listardetalles = await listadetallerutas();
                var obteneriddetalle = listardetalles.Where(b => b.IdRuta == objruta.IdRuta).ToList();
                foreach (var items in obteneriddetalle)
                {
                    await FireBase_Connect.Child("DetalleRutas/Registros").Child(items.IdDetalleRutaFireBase).DeleteAsync();
                }
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
