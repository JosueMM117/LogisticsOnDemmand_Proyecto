using FontAwesome.Sharp;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsPresentation;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas;
using LogisticsOnDemmand_Proyecto.Utility_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Xsl;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Rutas : Form
    {
        public CN_Rutas cn_rutas = new CN_Rutas();
        public CN_Vehiculos cn_vehiculos = new CN_Vehiculos();

        #region Constructor
        public frm_Rutas()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        GMarkerGoogle marcadorgoogle;
        GMapOverlay marcadoraverlay;

        //DataTable dtdestinos = new DataTable();
        int iddetalleruta_generado;
        double latitudinicial = 18.450217322488683;
        double longitudinicial = -69.92890886875865;
        
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidruta.Select();
            txtidruta.Clear();
            txtidvehiculo.Clear();
            txtidcliente.Clear();
            txttitulo.Clear();
            txtconcepto.Clear();
            txtcomentarios.Clear();
            txttiemporuta.Clear();
            nupcargas.Value = 1;
            cboprioridad.SelectedIndex = -1;
            cboestado.SelectedIndex = -1;
            dgvdetalleruta.Rows.Clear();
            foreach (Control controles in gbdatosvehiculo.Controls)
            {
                if (controles is Label)
                {
                    controles.Text = string.Empty;
                }
            }
            foreach (Control controles in gbclientes.Controls)
            {
                if (controles is TextBox)
                {
                    controles.Text = string.Empty;
                }
            }
            lblidvehiculo.Text = "";
            lblidvehiculo.Text = "IdVehículo:";
        }
        public void LimpiarDatosDetalle()
        {
            //Datos Vehículo
            txtidvehiculo.Clear();
            txtidcliente.Clear();
            txtnombrevehiculo.Text = string.Empty;
            txtnombreconductor.Text = string.Empty;

            //Datos Cliente
            txtnombrecliente.Clear();
            txtemailcliente.Clear();
            txtdireccioncliente.Clear();
            txttelefonocliente.Clear();
            txttelefono2cliente.Clear();

            //Datos Ubicacion Map
            txtlatitud.Text = "0";
            txtlongitud.Text = "0";
            marcadorgoogle.Position = new PointLatLng(latitudinicial, longitudinicial);
        }
        public void ActivarProcesado()
        {
            try
            {
                if (cboestado.SelectedIndex == 1)
                {
                    btneditar.Enabled = false;
                    btnborrar.Enabled = false;
                    foreach (Control item in pnlcontenedordatosruta.Controls)
                    {
                        if (item is Label) { }
                            //null
                        else
                            item.Enabled = false;
                    }
                    foreach (ToolStripMenuItem c in menubotones.Items)
                    {
                        if (c.Name == btnprocesar.Name)
                        {
                            btnprocesar.Text = "Desprocear";
                            break;
                        }
                    }
                }
                else
                {
                    btneditar.Enabled = true;
                    btnborrar.Enabled = true;
                    foreach (Control item in pnlcontenedordatosruta.Controls)
                    {
                        item.Enabled = true;
                    }
                    foreach (ToolStripMenuItem c in menubotones.Items)
                    {
                        if (c.Name == btnprocesar.Name)
                        {
                            btnprocesar.Text = "Procesar";
                            break;
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDatos()
        {
            try
            {
                //Habilidades
                List<OpcionCombo> listaprioridad = new List<OpcionCombo>
                {
                    new OpcionCombo() { IdPos = 0, Texto = "Prioridad Baja" },
                    new OpcionCombo() { IdPos = 1, Texto = "Prioridad Media" },
                    new OpcionCombo() { IdPos = 1, Texto = "Prioridad Alta" }
                };

                foreach (OpcionCombo item in listaprioridad)
                {
                    cboprioridad.Items.Add(new OpcionCombo() { IdPos = item.IdPos, Texto = item.Texto });
                }
                cboprioridad.DisplayMember = "Texto";
                cboprioridad.ValueMember = "Valor";
                cboprioridad.SelectedIndex = 0;

                //Estado
                List<OpcionCombo> listaestado = new List<OpcionCombo>
                {
                    new OpcionCombo() { IdPos = 0, Texto = "En Progreso" },
                    new OpcionCombo() { IdPos = 1, Texto = "Completada" }
                };
                foreach (OpcionCombo estados in listaestado)
                {
                    cboestado.Items.Add(new OpcionCombo() { IdPos = estados.IdPos, Texto = estados.Texto });
                }
                cboestado.DisplayMember = "Texto";
                cboestado.ValueMember = "IdPos";
                cboestado.SelectedIndex = -1;

                //InaHabilitar controles
                txtidvehiculo.Enabled = false;
                txtidcliente.Enabled = false;
                btnbuscarvehiculo.Enabled = false;
                btnbuscarcliente.Enabled = false;
                btnguardar.Enabled = false;
                cboestado.Enabled = false;
                dgvdetalleruta.Enabled = false;
                btnagregardestino.Enabled = false;
                foreach (Control controles in gbclientes.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarMapa()
        {
            try
            {
                //Cargar gMaprutas
                gMaprutas.DragButton = MouseButtons.Left;
                gMaprutas.CanDragMap = true;
                gMaprutas.MapProvider = GMapProviders.GoogleMap;
                gMaprutas.Position = new GMap.NET.PointLatLng(latitudinicial, longitudinicial);
                gMaprutas.AutoScroll = true;

                //Marcador
                marcadoraverlay = new GMapOverlay("Marcador");
                marcadorgoogle = new GMarkerGoogle(new PointLatLng(latitudinicial, longitudinicial), GMarkerGoogleType.red);
                marcadoraverlay.Markers.Add(marcadorgoogle); // Agregar al Mapa

                //Crear mensaje flotante
                marcadorgoogle.ToolTipMode = MarkerTooltipMode.Always;
                //marcadorgoogle.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", latitudinicial, longitudinicial);

                //Agregar el mensaje flotante a gMaprutas
                gMaprutas.Overlays.Add(marcadoraverlay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos

        //Load
        private void frm_Rutas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dtpfechaentrega.CustomFormat = "dd-MM-yyy";
            tbctlrutas.SelectTab(0);
            txtidruta.Select(); 
        }

        #region Click
        private async void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using(var modal = new frm_BuscarRutas())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtidruta.Text = string.Format("{0:0000}", modal._Ruta.IdRuta);
                        txttitulo.Text = modal._Ruta.Titulo;
                        txtconcepto.Text = modal._Ruta.Concepto;
                        txtcomentarios.Text = modal._Ruta.Comentarios;
                        txttiemporuta.Text = modal._Ruta.Tiempo_Ruta;
                        dtpfechaentrega.Value = modal._Ruta.Fecha_Entrega;
                        nupcargas.Value = modal._Ruta.Cargas;
                        foreach (OpcionCombo oc in cboprioridad.Items)
                        {
                            if (oc.Texto == modal._Ruta.Prioridad)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == modal._Ruta.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }

                        //Detalle Ruta
                        dgvdetalleruta.Rows.Clear();
                        List<CM_DetalleRuta> BuscarDatosDetalle = await cn_rutas.Listar_DetalleRutas();
                        foreach (var items in BuscarDatosDetalle)
                        {
                            if (items.IdRuta == modal._Ruta.IdRuta)
                            {
                                dgvdetalleruta.Rows.Add(new object[]
                                {
                                items.IdDetalleRuta,
                                items.IdRuta,
                                items.IdVehiculo,
                                items.NombreVehiculo,
                                items.Conductor,
                                items.DireccionEnvio,
                                items.Latitud,
                                items.Longitud,
                                items.NombreCliente,
                                items.TelefonoCliente1,
                                items.TelefonoCliente2,
                                items.EmailCliente,
                                items.FechaRegistro
                                });
                            }
                        }
                        ActivarProcesado();
                        //CargarMapa();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnadicionar.IconChar == IconChar.Ban)
                {
                    btnadicionar.IconChar = IconChar.FileCirclePlus;
                    btnadicionar.Text = "Adicionar";
                    btnguardar.Enabled = false;
                    btneditar.Enabled = true;
                    btnbuscar.Enabled = true;
                    btnborrar.Enabled = true;
                    btnprocesar.Enabled = true;
                    txtidruta.Enabled = true;
                    btnbuscarvehiculo.Enabled = false;
                    btnbuscarcliente.Enabled = false;
                    txtidvehiculo.Enabled = false;
                    txtidcliente.Enabled = false;
                    txtidruta.BackColor = Color.White;
                    txtidvehiculo.BackColor = Color.White;
                    txtidcliente.BackColor = Color.White;
                    cboestado.Enabled = false;
                    cboestado.SelectedIndex = -1;
                    dgvdetalleruta.Enabled = false;
                    btnagregardestino.Enabled = false;
                    Limpiar();
                    LimpiarDatosDetalle();
                }
                else
                {
                    btnadicionar.IconChar = IconChar.Ban;
                    btnadicionar.Text = "Cancelar";
                    btneditar.Enabled = false;
                    btnbuscar.Enabled = false;
                    btnborrar.Enabled = false;
                    btnprocesar.Enabled = false;
                    txtidruta.Enabled = false;
                    cboestado.Enabled = false;
                    btnbuscarvehiculo.Enabled = true;
                    btnbuscarcliente.Enabled = true;
                    txtidvehiculo.Enabled = true;
                    txtidcliente.Enabled = true;
                    dgvdetalleruta.Enabled = true;
                    btnagregardestino.Enabled = true;
                    Limpiar();
                    LimpiarDatosDetalle();

                    //Genererar IdRuta
                    List<CM_Rutas> BuscarDatos = await cn_rutas.Listar_Rutas();
                    int cant_registros = BuscarDatos.Select(b => b.IdRuta).Count();
                    int idgenerado;

                    if (cant_registros == 0)
                        idgenerado = 1;
                    else
                    {
                        cant_registros = BuscarDatos.Select(b => b.IdRuta).Max();
                        idgenerado = cant_registros + 1;
                    }
                    txtidruta.Text = string.Format("{0:0000}", idgenerado);
                    txtidruta.BackColor = Color.LightGreen;
                    txtidvehiculo.BackColor = Color.LightGreen;
                    txtidcliente.BackColor = Color.LightGreen;
                    btnguardar.Enabled = true;
                    cboestado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Rutas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw;
            }
        }
        private async void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                if (dgvdetalleruta.RowCount == 0)
                {
                    MessageBox.Show("Debe detallar los destinos destinos de esta ruta.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbctlrutas.SelectedIndex = 1;
                    return;
                }

                List<CM_DetalleRuta> detalle_ruta = new List<CM_DetalleRuta>();
                var objruta = new CM_Rutas()
                {
                    IdRuta = Convert.ToInt32(txtidruta.Text),
                    Titulo = txttitulo.Text,
                    Concepto = txtconcepto.Text,
                    Comentarios = txtcomentarios.Text,
                    Cargas = Convert.ToInt32(nupcargas.Value),
                    Fecha_Entrega = dtpfechaentrega.Value,
                    Tiempo_Ruta = txttiemporuta.Text,
                    Prioridad = cboprioridad.GetItemText(cboprioridad.SelectedItem),
                    Estado = cboestado.GetItemText(cboestado.SelectedItem),
                    FechaRegistro = Convert.ToDateTime(DateTime.Today.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };

                foreach (DataGridViewRow items_detalle in dgvdetalleruta.Rows)
                {
                    var objdetalleruta = new CM_DetalleRuta()
                    {
                        IdDetalleRuta = Convert.ToInt32(items_detalle.Cells["IdDetalleRuta"].Value),
                        IdRuta = Convert.ToInt32(items_detalle.Cells["IdRuta"].Value),
                        IdVehiculo = Convert.ToInt32(items_detalle.Cells["IdVehiculo"].Value),
                        NombreVehiculo = items_detalle.Cells["NombreVehiculo"].Value.ToString(),
                        Conductor = items_detalle.Cells["Conductor"].Value.ToString(),
                        DireccionEnvio = items_detalle.Cells["DireccionEnvio"].Value.ToString(),
                        Latitud = Convert.ToDouble(items_detalle.Cells["LatitudDestino"].Value),
                        Longitud = Convert.ToDouble(items_detalle.Cells["LongitudDestino"].Value),
                        IdCliente = Convert.ToInt32(items_detalle.Cells["IdCliente"].Value),
                        NombreCliente = items_detalle.Cells["NombreCliente"].Value.ToString(),
                        TelefonoCliente1 = items_detalle.Cells["Telefono1"].Value.ToString(),
                        TelefonoCliente2 = items_detalle.Cells["Telefono2"].Value.ToString(),
                        EmailCliente = items_detalle.Cells["EmailCliente"].Value.ToString(),
                        FechaRegistro = items_detalle.Cells["FechaRegistro"].Value.ToString()
                    };
                    detalle_ruta.Add(objdetalleruta);
                }

                if (txtidruta.BackColor == Color.LightGreen)
                {
                    bool respuesta = cn_rutas.Registrar_Rutas(objruta, out mensaje, detalle_ruta);
                    if (respuesta == true)
                    {
                        btnadicionar.IconChar = IconChar.FileCirclePlus;
                        btnadicionar.Text = "Adicionar";
                        btneditar.IconChar = IconChar.FilePen;
                        btneditar.Text = "Editar";
                        btnguardar.Enabled = false;
                        btneditar.Enabled = true;
                        btnborrar.Enabled = true;
                        btnadicionar.Enabled = true;
                        btnprocesar.Enabled = true;
                        btnbuscar.Enabled = true;
                        txtidruta.Enabled = true;
                        cboestado.Enabled = false;
                        btnbuscarvehiculo.Enabled = false;
                        btnbuscarcliente.Enabled = false;
                        txtidvehiculo.Enabled = false;
                        dgvdetalleruta.Enabled = false;
                        btnagregardestino.Enabled = false;
                        txtidruta.BackColor = Color.White;
                        txtidvehiculo.BackColor = Color.White;
                        txtidcliente.BackColor = Color.White;
                        foreach (Control controles in gbclientes.Controls)
                        {
                            if (controles is TextBox)
                            {
                                controles.Enabled = false;
                            }
                        }
                        //gMaprutas.Overlays.Remove(marcadoraverlay);
                    }
                    else
                        MessageBox.Show(mensaje, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool respuesta = await cn_rutas.Actualizar_InformacionRuta(objruta, detalle_ruta);
                    if (respuesta == true)
                    {
                        btnadicionar.IconChar = IconChar.FileCirclePlus;
                        btnadicionar.Text = "Adicionar";
                        btneditar.IconChar = IconChar.FilePen;
                        btneditar.Text = "Editar";
                        btnguardar.Enabled = false;
                        btneditar.Enabled = true;
                        btnborrar.Enabled = true;
                        btnadicionar.Enabled = true;
                        btnprocesar.Enabled = true;
                        btnbuscar.Enabled = true;
                        txtidruta.Enabled = true;
                        cboestado.Enabled = false;
                        dgvdetalleruta.Enabled = false;
                        btnbuscarvehiculo.Enabled = false;
                        btnbuscarcliente.Enabled = false;
                        txtidvehiculo.Enabled = false;
                        txtidruta.BackColor = Color.White;
                        txtidvehiculo.BackColor = Color.White;
                        txtidcliente.BackColor = Color.White;
                        foreach (Control controles in gbclientes.Controls)
                        {
                            if (controles is TextBox)
                            {
                                controles.Enabled = false;
                            }
                        }
                    }
                    else
                        MessageBox.Show("No se pudieron actualizar las informaciones.\n \n Proceso Candelado.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnprocesar_Click(object sender, EventArgs e)
        {

        }
        private async void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidruta.Text))
                {
                    MessageBox.Show("Debe seleccionar una ruta.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                List<CM_Rutas> BuscarDatos = await cn_rutas.Listar_Rutas();
                var validar = BuscarDatos.Where(b => b.IdRuta == Convert.ToInt32(txtidruta.Text)).FirstOrDefault();
                if (btneditar.IconChar == IconChar.Ban)
                {
                    btneditar.IconChar = IconChar.FilePen;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    btnborrar.Enabled = true;
                    txtidruta.Enabled = true;
                    cboestado.Enabled = false;
                    txtidruta.BackColor = Color.White;
                    txtidvehiculo.BackColor = Color.White;
                    txtidcliente.BackColor = Color.White;
                    txtidvehiculo.Enabled = false;
                    btnbuscarvehiculo.Enabled = false;
                    btnbuscarcliente.Enabled = false;
                    dgvdetalleruta.Enabled = false;
                    btnagregardestino.Enabled = false;
                    LimpiarDatosDetalle();

                    #region Cargar_Datos_IdSelecciado
                    //Datos Ruta
                    txtidruta.Text = string.Format("{0:0000}", Convert.ToInt32(txtidruta.Text));
                    txttitulo.Text = validar.Titulo;
                    txtconcepto.Text = validar.Concepto;
                    txtcomentarios.Text = validar.Comentarios;
                    dtpfechaentrega.Value = Convert.ToDateTime(validar.Fecha_Entrega);
                    txttiemporuta.Text = validar.Tiempo_Ruta;
                    nupcargas.Value = validar.Cargas;
                    foreach (OpcionCombo oc in cboprioridad.Items)
                    {
                        if (oc.Texto == validar.Prioridad)
                        {
                            int indice_combo = cboprioridad.Items.IndexOf(oc);
                            cboprioridad.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (oc.Texto == validar.Estado)
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    //Detalle Ruta
                    dgvdetalleruta.Rows.Clear();
                    List<CM_DetalleRuta> BuscarDatosDetalle = await cn_rutas.Listar_DetalleRutas();
                    foreach (var items in BuscarDatosDetalle)
                    {
                        if (items.IdRuta == validar.IdRuta)
                        {
                            dgvdetalleruta.Rows.Add(new object[]
                            {
                                    items.IdDetalleRuta,
                                    items.IdRuta,
                                    items.IdVehiculo,
                                    items.NombreVehiculo,
                                    items.Conductor,
                                    items.DireccionEnvio,
                                    items.Latitud,
                                    items.Longitud,
                                    items.NombreCliente,
                                    items.TelefonoCliente1,
                                    items.TelefonoCliente2,
                                    items.EmailCliente,
                                    items.FechaRegistro
                            });
                        }
                    }
                    #endregion
                }
                else
                {
                    if (validar != null)
                    {
                        btneditar.IconChar = IconChar.Ban;
                        btneditar.Text = "Cancelar";
                        btnguardar.Enabled = true;
                        btnadicionar.Enabled = false;
                        btnborrar.Enabled = false;
                        btnbuscar.Enabled = false;
                        btnbuscarvehiculo.Enabled = true;
                        btnbuscarcliente.Enabled = true;
                        btnprocesar.Enabled = false;
                        cboestado.Enabled = true;
                        txtidruta.Enabled = false;
                        btnprocesar.Enabled = true;
                        txtidruta.BackColor = Color.Khaki;
                        txtidvehiculo.BackColor = Color.Khaki;
                        txtidcliente.BackColor = Color.Khaki;
                        txtidvehiculo.Enabled = true;
                        dgvdetalleruta.Enabled = true;
                        btnagregardestino.Enabled = true;
                        LimpiarDatosDetalle();

                        #region Cargar_Datos_IdSeleccionado

                        //Datos Ruta
                        txtidruta.Text = string.Format("{0:0000}", Convert.ToInt32(txtidruta.Text));
                        txttitulo.Text = validar.Titulo;
                        txtconcepto.Text = validar.Concepto;
                        txtcomentarios.Text = validar.Comentarios;
                        dtpfechaentrega.Value = Convert.ToDateTime(validar.Fecha_Entrega);
                        txttiemporuta.Text = validar.Tiempo_Ruta;
                        nupcargas.Value = validar.Cargas;
                        foreach (OpcionCombo oc in cboprioridad.Items)
                        {
                            if (oc.Texto == validar.Prioridad)
                            {
                                int indice_combo = cboprioridad.Items.IndexOf(oc);
                                cboprioridad.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }

                        //Detalle Ruta
                        dgvdetalleruta.Rows.Clear();
                        List<CM_DetalleRuta> BuscarDatosDetalle = await cn_rutas.Listar_DetalleRutas();
                        foreach (var items in BuscarDatosDetalle)
                        {
                            if (items.IdRuta == validar.IdRuta)
                            {
                                dgvdetalleruta.Rows.Add(new object[]
                                {
                                    items.IdDetalleRuta,
                                    items.IdRuta,
                                    items.IdVehiculo,
                                    items.NombreVehiculo,
                                    items.Conductor,
                                    items.DireccionEnvio,
                                    items.Latitud,
                                    items.Longitud,
                                    items.NombreCliente,
                                    items.TelefonoCliente1,
                                    items.TelefonoCliente2,
                                    items.EmailCliente,
                                    items.FechaRegistro
                                });
                            }
                        }

                        #endregion
                    }
                    else
                        MessageBox.Show("La ruta no existe.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtidruta.Text))
                {
                    MessageBox.Show("Debe seleccionar una ruta.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var objruta = new CM_Rutas
                {
                    IdRuta = Convert.ToInt32(txtidruta.Text)
                };

                if (MessageBox.Show("¿Seguro que desea borrar la ruta?", "Rutas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = await cn_rutas.Borrar_Rutas(objruta);
                    if (respuesta == true)
                    {
                        Limpiar();
                        dgvdetalleruta.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btncargarruta_Click(object sender, EventArgs e)
        {
            try
            {
                MapRoute rutasdireccion;
                GMap.NET.WindowsForms.GMapRoute rutaobtenida;
                GMapOverlay Ruta = new GMapOverlay("CapaRutas");
                List<PointLatLng> destinos = new List<PointLatLng>();

                //Almacenar los puntos;
                double latitud, longitud;
                string nombrecliente;
                
                //Buscar Destinos en el dgvdetalleruta
                for (int irow = 0; irow < dgvdetalleruta.Rows.Count; irow++)
                {
                    latitud = Convert.ToDouble(dgvdetalleruta.Rows[irow].Cells["LatitudDestino"].Value);
                    longitud = Convert.ToDouble(dgvdetalleruta.Rows[irow].Cells["LongitudDestino"].Value);
                    nombrecliente = dgvdetalleruta.Rows[irow].Cells["NombreCliente"].Value.ToString();
                    destinos.Add(new PointLatLng(latitud,longitud));
                    marcadorgoogle.Position = new PointLatLng(latitud, longitud);
                    marcadorgoogle.ToolTipText = string.Format($"\n{nombrecliente}\n");
                }

                //Cargar puntos de destinos en gMaprutas
                GMap.NET.WindowsForms.GMapRoute Ruta_Destinos = new GMap.NET.WindowsForms.GMapRoute(destinos, "CapaRutas");
                Ruta.Routes.Add(Ruta_Destinos);
                gMaprutas.Overlays.Add(Ruta);
                
                //Actualizar destinos en gMaprutas
                gMaprutas.Zoom = gMaprutas.Zoom + 1;
                gMaprutas.Zoom = gMaprutas.Zoom - 1;

                
                //GMapOverlay caparutas;
                //// creamos las variables para almacenar los datos
                //double lat, lng;
                //// tomamos los datos del grid
                //for (int filas = 0; filas < DataGridView2.Rows.Count - 1; filas++)
                //{

                //    lat = Convert.ToDouble(DataGridView2.Rows[filas].Cells[2].Value);
                //    lng = Convert.ToDouble(DataGridView2.Rows[filas].Cells[3].Value);

                //    //En este apartado añades un punto a tu lista
                //    puntos.Add(new PointLatLng(lat, lng));

                //    //Si queremos utilizar 2 elementos de la lista puntos debemos estar seguros de que existen, al menos,
                //    //esos 2 elementos, es decir en la primera iteración del bucle no debo realizar esta parte
                //    if (puntos.Count() >= 2)
                //    {
                //        rutasdireccion =
                //            GoogleMapProvider.Instance.GetRoute(puntos[filas], puntos[filas + 1], true, false, 10);
                //        rutaobtenida = new GMapRoute(rutasdireccion.Points, "Ruta Ubicación");
                //        caparutas = new GMapOverlay("capa de la ruta");
                //        caparutas.Routes.Add(rutaobtenida);
                //        gMapControl1.Overlays.Add(caparutas);
                //        // para actualizar
                //        //gMapControl1.Zoom = gMapControl1.Zoom + 1;
                //        //gMapControl1.Zoom = gMapControl1.Zoom - 1;
                //        gMapControl1.UpdateRouteLocalPosition(rutaobtenida);
                //    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscarvehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new frm_BuscarVehiculos())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (modal._Vehiculos.Estado == "Activo")
                        {
                            txtidvehiculo.Text = string.Format("{0:000}", modal._Vehiculos.IdVehiculo);
                            txtnombrevehiculo.Text = modal._Vehiculos.NombreVehiculo;
                            txtnombreconductor.Text = modal._Vehiculos.Conductor.NombreCompleto;
                        }
                        else
                            MessageBox.Show("El Vehiculo se encuentra inactivo.","Rutas",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (var modal = new frm_BuscarClientes())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        txtidcliente.Text = string.Format("{0:0000}", modal._Clientes.IdCliente);
                        txtnombrecliente.Text = modal._Clientes.NombreCompleto;
                        txtemailcliente.Text = modal._Clientes.Email;
                        txtdireccioncliente.Text = modal._Clientes.Direccion;
                        txttelefonocliente.Text = modal._Clientes.Telefono;
                        txttelefono2cliente.Text = modal._Clientes.Telefono2;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == modal._Clientes.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnagregardestino_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregar destinos al dtdestinos
                if (string.IsNullOrEmpty(txtidvehiculo.Text))
                {
                    MessageBox.Show("Debe indicar un vehículo.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtidvehiculo.Select();
                    return;
                }
                else if (string.IsNullOrEmpty(txtidcliente.Text))
                {
                    MessageBox.Show("Debe indicar un cliente.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtidcliente.Select();
                    return;
                }
                else if (txtlatitud.Text.Trim().Equals("0") || txtlongitud.Text.Trim().Equals("0"))
                {
                    MessageBox.Show("Debe indicar la ubicación del destino.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbctlrutas.SelectTab(tabpgmapa);
                    return;
                }
                
                //Validar existencia del vehiculo seleccioando
                List<CM_Vehiculos> BuscarDatosVehiculos = await cn_vehiculos.Listar_Vehículos();
                if (txtidvehiculo.Text == "")
                    txtidvehiculo.Text = "0";
                var validar_vehiculo = BuscarDatosVehiculos.Where(b => b.IdVehiculo == Convert.ToInt32(txtidvehiculo.Text)).FirstOrDefault();
                if (validar_vehiculo == null)
                {
                    MessageBox.Show("La vehículo no existe", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtidvehiculo.SelectAll();
                    txtnombreconductor.Text = "";
                    txtnombrevehiculo.Text = "";
                    return;
                }

                //Validar existencia del cliente seleccioando
                List<CM_Clientes> BuscarDatosClientes = await new CN_Clientes().Listar_Clientes();
                if (txtidcliente.Text == "")
                    txtidcliente.Text = "0";
                var validar_cliente = BuscarDatosClientes.Where(b => b.IdCliente == Convert.ToInt32(txtidcliente.Text)).FirstOrDefault();
                if (validar_cliente == null)
                {
                    MessageBox.Show("La cliente no existe", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtidcliente.SelectAll();
                    foreach (Control controls in pnlcontenedordatosclientes.Controls)
                    {
                        if (controls is TextBox)
                        {
                            controls.Text = string.Empty;
                        }
                    }
                    return;
                }

                if (string.IsNullOrEmpty(txtnombrecliente.Text))
                    MessageBox.Show("Debe indicar el nombre del cliente.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (string.IsNullOrEmpty(txttelefonocliente.Text) && string.IsNullOrEmpty(txttelefono2cliente.Text))
                    MessageBox.Show("Debe indicar al menos un número de contacto.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (string.IsNullOrEmpty(txtdireccioncliente.Text))
                    MessageBox.Show("Debe indicar la direccion de envío.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    //Generar el IdDetalleRuta
                    int irows = 0;
                    if (dgvdetalleruta.RowCount == 0)
                        irows = 1;
                    else
                    {
                        foreach (DataGridViewRow rows in dgvdetalleruta.Rows)
                        {
                            irows++;
                            if (irows == dgvdetalleruta.RowCount)
                            {
                                irows = irows + 1;
                            }
                        }
                    }
                    
                    //Agregar al detalle
                    dgvdetalleruta.Rows.Add(new object[]
                    {
                        string.Format("{0:0000}",irows),
                        Convert.ToUInt32(txtidruta.Text),
                        Convert.ToInt32(txtidvehiculo.Text),
                        txtnombrevehiculo.Text,
                        txtnombreconductor.Text,
                        txtdireccioncliente.Text,
                        Convert.ToDouble(txtlatitud.Text),
                        Convert.ToDouble(txtlongitud.Text),
                        Convert.ToInt32(txtidcliente.Text),
                        txtnombrecliente.Text,
                        txttelefonocliente.Text,
                        txttelefono2cliente.Text,
                        txtemailcliente.Text,
                        DateTime.Today.ToString("dd-MMM-yyy HH:mm:ss tt")
                    });
                    LimpiarDatosDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gMaprutas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //obtener ubicacion seleccionada de gMaprutas
                double latitud = gMaprutas.FromLocalToLatLng(e.X, e.Y).Lat;
                double longitud = gMaprutas.FromLocalToLatLng(e.X, e.Y).Lng;
                txtlatitud.Text = latitud.ToString();
                txtlongitud.Text = longitud.ToString();

                //Mover el marcador a la posicion seleccionada por el usuario en el mapa
                marcadorgoogle.Position = new PointLatLng(latitud, longitud);
                marcadorgoogle.ToolTipText = string.Format("\n Latitud:{0} \n Longitud:{1}", latitud, longitud);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncargarubicacionactual_Click(object sender, EventArgs e)
        {
            gMaprutas.Position = new GMap.NET.PointLatLng(latitudinicial, longitudinicial);
            gMaprutas.Zoom = 18;
        }
        #endregion

        //MouseLeave
        private async void txtidvehiculo_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //KeyPress
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private async void txtidvehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    int codigo = int.Parse(txtidvehiculo.Text);
                    List<CM_Vehiculos> BuscarDatos = await cn_vehiculos.Listar_Vehículos();
                    var validar = BuscarDatos.Where(b => b.IdVehiculo == codigo).FirstOrDefault();
                    if (validar != null)
                    {
                        if (validar.Estado == "Activo")
                        {
                            e.SuppressKeyPress = true;
                            txtidvehiculo.Text = string.Format("{0:000}", validar.IdVehiculo);
                            txtnombrevehiculo.Text = validar.NombreVehiculo;
                            txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                            txtidvehiculo.SelectionStart = txtidvehiculo.MaxLength;
                        }
                        else
                        {
                            MessageBox.Show("El Vehiculo se encuentra inactivo.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtidvehiculo.Clear();
                            foreach (Control controles in gbdatosvehiculo.Controls)
                            {
                                if (controles is Label)
                                {
                                    controles.Text = string.Empty;
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("La vehículo no existe", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidvehiculo.SelectAll();
                        txtnombreconductor.Text = "";
                        txtnombrevehiculo.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void txtidruta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    if (string.IsNullOrEmpty(txtidruta.Text))
                    {
                        MessageBox.Show("Debe indicar el Id de la ruta.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int codigo = int.Parse(txtidruta.Text);
                    List<CM_Rutas> BuscarDatos = await cn_rutas.Listar_Rutas();
                    var validar = BuscarDatos.Where(b => b.IdRuta == codigo).FirstOrDefault();
                    if (validar != null)
                    {
                        e.SuppressKeyPress = true;
                        txtidruta.Text = string.Format("{0:0000}", codigo);
                        txttitulo.Text = validar.Titulo;
                        txtconcepto.Text = validar.Concepto;
                        txtcomentarios.Text = validar.Comentarios;
                        txttiemporuta.Text = validar.Tiempo_Ruta;
                        dtpfechaentrega.Value = validar.Fecha_Entrega;
                        nupcargas.Value = validar.Cargas;
                        foreach (OpcionCombo oc in cboprioridad.Items)
                        {
                            if (oc.Texto == validar.Prioridad)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        //Detalle Ruta
                        dgvdetalleruta.Rows.Clear();
                        List<CM_DetalleRuta> BuscarDatosDetalle = await cn_rutas.Listar_DetalleRutas();
                        foreach (var items in BuscarDatosDetalle)
                        {
                            if (items.IdRuta == validar.IdRuta)
                            {
                                dgvdetalleruta.Rows.Add(new object[]
                                {
                                    items.IdDetalleRuta,
                                    items.IdRuta,
                                    items.IdVehiculo,
                                    items.NombreVehiculo,
                                    items.Conductor,
                                    items.DireccionEnvio,
                                    items.Latitud,
                                    items.Longitud,
                                    items.NombreCliente,
                                    items.TelefonoCliente1,
                                    items.TelefonoCliente2,
                                    items.EmailCliente,
                                    items.FechaRegistro
                                });
                            }
                        }
                        txtidruta.SelectionStart = txtidruta.MaxLength;
                        //CargarMapa();
                    }
                    else
                    {
                        MessageBox.Show("La Ruta no existe", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidruta.SelectAll();
                        dgvdetalleruta.Rows.Clear();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void txtidcliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    if (string.IsNullOrEmpty(txtidcliente.Text))
                    {
                        MessageBox.Show("Debe indicar el Id del cliente.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int codigo = int.Parse(txtidcliente.Text);
                    List<CM_Clientes> BuscarDatos = await new CN_Clientes().Listar_Clientes();
                    var validar = BuscarDatos.Where(b => b.IdCliente == codigo).FirstOrDefault();
                    if (validar != null)
                    {
                        e.SuppressKeyPress = true;
                        txtidcliente.Text = string.Format("{0:0000}", codigo);
                        txtnombrecliente.Text = validar.NombreCompleto;
                        txtemailcliente.Text = validar.Email;
                        txtdireccioncliente.Text = validar.Direccion;
                        txttelefonocliente.Text = validar.Telefono;
                        txttelefono2cliente.Text = validar.Telefono2;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        txtidcliente.SelectionStart = txtidcliente.MaxLength;
                    }
                    else
                    {
                        MessageBox.Show("La cliente no existe", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidcliente.SelectAll();
                        foreach (Control item in pnlcontenedordatosclientes.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Selected TabControl
        private void tbctlvehiculos_Selected(object sender, TabControlEventArgs e)
        {
            CargarMapa();
        }

        //CellContentClick
        private void dgvdestinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow >= 0 && icolumn >= 0)
                {
                    //txtlatitud.Text = dgvdetalleruta.Rows[irow].Cells["Latitud"].Value.ToString();
                    //txtlongitud.Text = dgvdetalleruta.Rows[irow].Cells["Longitud"].Value.ToString();
                    ////Asignamos las posicion del destino seleccionado
                    //marcadorgoogle.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
                    //gMaprutas.Position = marcadorgoogle.Position;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CellDoubleClick
        private void dgvdetalleruta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow >= 0 && icolumn >= 0)
                {
                    //Datos cliente
                    txtnombrecliente.Text = dgvdetalleruta.Rows[irow].Cells["NombreCliente"].Value.ToString();
                    txttelefonocliente.Text = dgvdetalleruta.Rows[irow].Cells["Telefono1"].Value.ToString();
                    txttelefono2cliente.Text = dgvdetalleruta.Rows[irow].Cells["Telefono2"].Value.ToString();
                    txtemailcliente.Text = dgvdetalleruta.Rows[irow].Cells["EmailCliente"].Value.ToString();
                    txtdireccioncliente.Text = dgvdetalleruta.Rows[irow].Cells["DireccionEnvio"].Value.ToString();

                    //Datos Vehiculo
                    txtidvehiculo.Text = string.Format("{0:0000}", dgvdetalleruta.Rows[irow].Cells["IdVehiculo"].Value);
                    txtnombrevehiculo.Text = dgvdetalleruta.Rows[irow].Cells["NombreVehiculo"].Value.ToString();
                    txtnombreconductor.Text = dgvdetalleruta.Rows[irow].Cells["Conductor"].Value.ToString();

                    //Datos Destino
                    txtlatitud.Text = dgvdetalleruta.Rows[irow].Cells["LatitudDestino"].Value.ToString();
                    txtlongitud.Text = dgvdetalleruta.Rows[irow].Cells["LongitudDestino"].Value.ToString();
                    marcadorgoogle.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
                    marcadorgoogle.ToolTipText = string.Format("\n Latitud:{0} \n Longitud:{1}", Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));

                    //GMapOverlay marcadoraverlay = new GMapOverlay();
                    //gMaprutas.Overlays.Remove(marcadoraverlay = null);

                    //Remover Fila
                    dgvdetalleruta.Rows.RemoveAt(irow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

       
    }
}
