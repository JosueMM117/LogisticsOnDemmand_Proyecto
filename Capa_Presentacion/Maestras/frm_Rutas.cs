using FontAwesome.Sharp;
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
        #region Constructor
        public frm_Rutas()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidruta.Select();
            txtidruta.Clear();

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
        #endregion

        #region Eventos

        //Load
        private void frm_Rutas_Load(object sender, EventArgs e)
        {
            txtidruta.Select();
            txtidvehiculo.Enabled = false;
            btnbuscarvehiculo.Enabled = false;
            cboestado.Enabled = false;

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
                    cboestado.Enabled = true;
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
                    //cboestado.SelectedIndex = 0;
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

        //KeyPress
        private void txtidvehiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private void txtidruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }

        #endregion

        #endregion

        
    }
}
