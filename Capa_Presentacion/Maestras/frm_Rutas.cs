using FontAwesome.Sharp;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas;
using LogisticsOnDemmand_Proyecto.Utility_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        DataTable dtdestinos = new DataTable();
        int iddestinoselecciado = 0;
        double latitudinicial = 18.450217322488683;
        double lonitudinicial = -69.92890886875865;
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidruta.Select();
            txtidruta.Clear();
            txtidvehiculo.Clear();
            txtnombreconductor.Text = "";
            txtnombrevehiculo.Text = "";
            txthabilidadvehiculo.Text = "";
            //txtidconductor.Text = "";
            //txtnombrevehiculo.Clear();
            //txtnombreconductor.Text = "";
            //txtmarca.Clear();
            //txtidentificacion.Clear();
            //nupcargamaxima.Value = 1;
            //nupcargaminima.Value = 1;
            //nuphoraiodisponibilidad.Value = 1;
            //cbohabilidad.SelectedIndex = -1;
            //cboestado.SelectedIndex = -1;

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

                //Cargar columnas dtdestino
                dtdestinos.Columns.Add(new DataColumn("IdDestino"));
                dtdestinos.Columns.Add(new DataColumn("Descripción"));
                dtdestinos.Columns.Add(new DataColumn("Latitud"));
                dtdestinos.Columns.Add(new DataColumn("Longitud"));
                
                dgvdestinos.DataSource = dtdestinos;
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
            txtidruta.Select();
            txtidvehiculo.Enabled = false;
            btnbuscarvehiculo.Enabled = false;
            cboestado.Enabled = false;
            dtpfechaentrega.CustomFormat = "dd-MM-yyy";
            tbctlvehiculos.SelectTab(0);
        }

        #region Click
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["frm_BuscarRutas"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new frm_BuscarRutas();
                open.ShowDialog();
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
                    txtidvehiculo.Enabled = false;
                    txtidruta.BackColor = Color.White;
                    txtidvehiculo.BackColor = Color.White;
                    cboestado.Enabled = false;
                    cboestado.SelectedIndex = -1;
                    Limpiar();
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
                    txtidvehiculo.Enabled = true;
                    Limpiar();

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
                    txtidvehiculo.Enabled = false;
                    btnbuscarvehiculo.Enabled = false;

                    #region Cargar_Datos_IdSelecciado
                    //Datos Ruta
                    txtidruta.Text = string.Format("{0:0000}", Convert.ToInt32(txtidruta.Text));
                    txttitulo.Text = validar.Titulo;
                    txtconcepto.Text = validar.Concepto;
                    txtdireccion.Text = validar.Direccion;
                    txtcomentarios.Text = validar.Comentarios;
                    dtpfechaentrega.Value = Convert.ToDateTime(validar.Fecha_Entrega);
                    txthoradesde.Text = validar.Ventana_Tiempo_Desde;
                    txthorahasta.Text = validar.Ventana_Tiempo_Hasta;
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
                    //datalle rutas

                    //Datos Vehiculo
                    txtidvehiculo.Text = string.Format("{0:000}", validar.Vehiculo.IdVehiculo);
                    txtnombrevehiculo.Text = validar.Vehiculo.NombreVehiculo;
                    txtnombreconductor.Text = validar.Vehiculo.Conductor.NombreCompleto;
                    txthabilidadvehiculo.Text = validar.Vehiculo.Habilidades.Descripcion;

                    //Datos Cliente
                    txtnombrecliente.Text = validar.Nombre_Cliente;
                    txttelefonocliente.Text = validar.Telefono_Cliente;
                    txttelefono2cliente.Text = validar.Telefono2_Cliente;
                    txtemailcliente.Text = validar.Email_Cliente;
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
                        btnprocesar.Enabled = false;
                        cboestado.Enabled = true;
                        txtidruta.Enabled = false;
                        btnprocesar.Enabled = true;
                        txtidruta.BackColor = Color.Khaki;
                        txtidvehiculo.BackColor = Color.Khaki;
                        txtidvehiculo.Enabled = true;

                        #region Cargar_Datos_IdSeleccionado

                        //Datos Ruta
                        txtidruta.Text = string.Format("{0:0000}", Convert.ToInt32(txtidruta.Text));
                        txttitulo.Text = validar.Titulo;
                        txtconcepto.Text = validar.Concepto;
                        txtdireccion.Text = validar.Direccion;
                        txtcomentarios.Text = validar.Comentarios;
                        dtpfechaentrega.Value = Convert.ToDateTime(validar.Fecha_Entrega);
                        txthoradesde.Text = validar.Ventana_Tiempo_Desde;
                        txthorahasta.Text = validar.Ventana_Tiempo_Hasta;
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
                        //datalle rutas

                        //Datos Vehiculo
                        txtidvehiculo.Text = string.Format("{0:000}", validar.Vehiculo.IdVehiculo);
                        txtnombrevehiculo.Text = validar.Vehiculo.NombreVehiculo;
                        txtnombreconductor.Text = validar.Vehiculo.Conductor.NombreCompleto;
                        txthabilidadvehiculo.Text = validar.Vehiculo.Habilidades.Descripcion;

                        //Datos Cliente
                        txtnombrecliente.Text = validar.Nombre_Cliente;
                        txttelefonocliente.Text = validar.Telefono_Cliente;
                        txttelefono2cliente.Text = validar.Telefono2_Cliente;
                        txtemailcliente.Text = validar.Email_Cliente;

                        #endregion
                    }
                    else
                    MessageBox.Show("Debe seleccionar la ruta que desea editar.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                var objvehiculo = new CM_Vehiculos
                {
                    IdVehiculo = Convert.ToInt32(txtidvehiculo.Text)
                };

                if (MessageBox.Show("¿Seguro que desea borrar la ruta?", "Rutas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpiar();
                    //Validar que la ruta no tenga algun destino completado, esto debe realizarse en la tabla de 
                    //detalle ruta.

                        //List<CM_Rutas> BuscarDatos = await cn_rutas.Listar_Rutas();
                        //var validar_datos = BuscarDatos.Where(b => b.IdRuta == objvehiculo.IdVehiculo).FirstOrDefault();
                        //if (validar_datos == null)
                        //{
                        //    bool respuesta = await cnvehiculos.Borrar_Habilidades(objhabilidad);
                        //    if (respuesta == true)
                        //    {

                        //    }
                        //}
                    //else
                    //    MessageBox.Show("No puede borrar este vehículo porque tiene rutas pendientes por entregar.", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            txthabilidadvehiculo.Text = modal._Vehiculos.Habilidades.Descripcion;
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
        private void btnagregardestino_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregar destinos al dtdestinos
                dtdestinos.Rows.Add(1, "Destino Inicial", 18.450217322488683,-69.92890886875865);
                dtdestinos.Rows.Add(1, "Destino Final", 18.450217322488683, -69.92890886875865);
                dtdestinos.Rows.Add(2, "Destino Final", 18.450217322488683, -69.92890886875865);
                dtdestinos.Rows.Add(2, "Destino Final", 18.450217322488683, -69.92890886875865);

               
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
                marcadorgoogle.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", latitud, longitud);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncargarubicacionactual_Click(object sender, EventArgs e)
        {
            gMaprutas.Position = new GMap.NET.PointLatLng(latitudinicial, lonitudinicial);
        }


        #endregion

        //KeyPress
        private void txtidvehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private void txtidruta_KeyPress(object sender, KeyPressEventArgs e)
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
                            txthabilidadvehiculo.Text = validar.Habilidades.Descripcion;
                            txtidvehiculo.SelectionStart = txtidvehiculo.MaxLength;
                        }
                        else
                        {
                            MessageBox.Show("El Vehiculo se encuentra inactivo.", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtidvehiculo.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La vehículo no existe", "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidvehiculo.SelectAll();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Selected TabControl
        private void tbctlvehiculos_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                //Cargar gMaprutas
                gMaprutas.DragButton = MouseButtons.Left;
                gMaprutas.CanDragMap = true;
                gMaprutas.MapProvider = GMapProviders.GoogleMap;
                gMaprutas.Position = new GMap.NET.PointLatLng(latitudinicial, lonitudinicial);
                gMaprutas.AutoScroll = true;

                //Marcador
                marcadoraverlay = new GMapOverlay("Marcador");
                marcadorgoogle = new GMarkerGoogle(new PointLatLng(latitudinicial, lonitudinicial), GMarkerGoogleType.red);
                marcadoraverlay.Markers.Add(marcadorgoogle); // Agregar al Mapa

                //Crear mensaje flotante
                marcadorgoogle.ToolTipMode = MarkerTooltipMode.Always;
                //marcadorgoogle.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud:{1}", latitudinicial, lonitudinicial);

                //Agregar el mensaje flotante a gMaprutas
                gMaprutas.Overlays.Add(marcadoraverlay);

                //Ocultar Columnas
                dgvdestinos.Columns[2].Visible = false;
                dgvdestinos.Columns[3].Visible = false;
                dgvdestinos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    txtlatitud.Text = dgvdestinos.Rows[irow].Cells["Latitud"].Value.ToString();
                    txtlongitud.Text = dgvdestinos.Rows[irow].Cells["Longitud"].Value.ToString();
                    //Asignamos las posicion del destino seleccionado
                    marcadorgoogle.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
                    gMaprutas.Position = marcadorgoogle.Position;
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
