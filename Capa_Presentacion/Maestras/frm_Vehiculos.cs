using FontAwesome.Sharp;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
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

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Vehiculos : Form
    {
        public CN_Vehiculos cnvehiculos = new CN_Vehiculos();
        #region Constructor
        public frm_Vehiculos()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidvehiculo.Clear();
            txtidconductor.Text = "";
            txtnombrevehiculo.Clear();
            txtnombreconductor.Text = "";
            txtmarca.Clear();
            txtidentificacion.Clear();
            txtcargamaxima.Clear();
            txtcargaminima.Clear();
            txthoraiodisponibilidad.Clear();
            cbohabilidad.SelectedIndex = -1;
            cboestado.SelectedIndex = -1;
        }
        #endregion

        #region Eventos

        //Load 
        private void frm_Vehiculos_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
        }

        #region Click
        private void btnhabilidad_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["frm_Habilidades"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new frm_Habilidades();
                open.ShowDialog();
            }
        }
        private void btnbuscarconductor_Click(object sender, EventArgs e)
        {
            using (var new_modal = new frm_BuscarUsuarios())
            {
                var resultado = new_modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    if (new_modal._Usuarios.Estado == "Activo")
                    {
                        txtidconductor.Text = new_modal._Usuarios.IdUsuario.ToString();
                        txtnombreconductor.Text = new_modal._Usuarios.NombreCompleto;
                    }
                    else
                        MessageBox.Show("El conductor se encuentra inactivo.", "Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private async void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnadicionar.IconChar == IconChar.Ban)
                {
                    btnadicionar.IconChar = IconChar.Plus;
                    btnadicionar.Text = "Adicionar";
                    btnguardar.Enabled = false;
                    btneditar.Enabled = true;
                    btnbuscar.Enabled = true;
                    txtidvehiculo.Enabled = true;
                    txtidvehiculo.BackColor = Color.White;
                    Limpiar();
                }
                else
                {
                    btnadicionar.IconChar = IconChar.Ban;
                    btnadicionar.Text = "Cancelar";
                    btnguardar.Enabled = true;
                    btneditar.Enabled = false;
                    btnbuscar.Enabled = false;
                    txtidvehiculo.Enabled = false;
                    txtidvehiculo.BackColor = Color.LightGreen;
                    Limpiar();
                    List<CM_Vehiculos> BuscarDatos = await cnvehiculos.Listar_Vehículos();
                    int cant_registros = BuscarDatos.Select(b => b.IdVehiculo).Count();
                    int idgenerado;

                    if (cant_registros == 0)
                        idgenerado = 1;
                    else
                    {
                        cant_registros = BuscarDatos.Select(b => b.IdVehiculo).Max();
                        idgenerado = cant_registros + 1;
                    }
                    txtidvehiculo.Text = string.Format("{0:0000}", idgenerado); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            btnadicionar.IconChar = IconChar.Plus;
            btnadicionar.Text = "Adicionar";
            btneditar.IconChar = IconChar.PenToSquare;
            btneditar.Text = "Editar";
            btnguardar.Enabled = false;
            btneditar.Enabled = true;
            btnadicionar.Enabled = true;
            btnbuscar.Enabled = true;
            txtidvehiculo.Enabled = true;

            var objvehiculo = new CM_Vehiculos()
            {
                IdVehiculo = Convert.ToInt32(txtidvehiculo.Text),
                NombreVehiculo = txtnombrevehiculo.Text,
                Marca = txtmarca.Text,
                CargaMaxima = Convert.ToDecimal(txtcargamaxima.Text),
                //CargaManima = Convert.ToDecimal(txtcargaminima.Text),
                ////Identificacion = txtidentificacion.Text,
                //HorarioDisponibilidad = Convert.ToInt32(txthoraiodisponibilidad.Text),
                //Conductor = new CM_Usuarios
                //{
                //    IdUsuario = Convert.ToInt32(txtidconductor.Text),
                //    //NombreCompleto = txtnombreconductor.Text
                //},
                ////Habilidades = new CM_Habilidades
                ////{
                ////    IdHabilidad = 
                ////},
                //Estado = cboestado.GetItemText(cboestado.SelectedItem),
                //FechaRegistro = Convert.ToDateTime(DateTime.Now.Date.ToString("dd-MMM-yyy HH:mm:ss tt"))
            };
        }
        private async void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<CM_Vehiculos> BuscarDatos = await cnvehiculos.Listar_Vehículos();
                var validar = BuscarDatos.Where(b => b.IdVehiculo == Convert.ToInt32(txtidvehiculo.Text)).FirstOrDefault();
                if (btneditar.IconChar == IconChar.Ban)
                {
                    btneditar.IconChar = IconChar.PenToSquare;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    txtidvehiculo.Enabled = true;
                    txtidvehiculo.BackColor = Color.White;
                    #region Cargar_Datos_IdSelecciado
                    txtidvehiculo.Text = string.Format("{0:0000}", Convert.ToInt32(txtidvehiculo.Text));
                    txtnombrevehiculo.Text = validar.NombreVehiculo;
                    txtidconductor.Text = validar.Conductor.IdUsuario.ToString();
                    txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                    txtmarca.Text = validar.Marca;
                    txtidentificacion.Text = validar.Identificacion;
                    txtcargamaxima.Text = Convert.ToDecimal(validar.CargaMaxima).ToString("N2");
                    txtcargaminima.Text = Convert.ToDecimal(validar.CargaManima).ToString("N2");
                    txthoraiodisponibilidad.Text = Convert.ToInt32(validar.HorarioDisponibilidad).ToString("N0");
                    foreach (OpcionCombo oc in cbohabilidad.Items)
                    {
                        if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(validar.Habilidades.IdHabilidad))
                        {
                            int indice_combo = cbohabilidad.Items.IndexOf(oc);
                            cbohabilidad.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (oc.Texto == validar.Habilidades.Descripcion)
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    #endregion
                }
                else
                {
                    if (validar != null)
                    {
                        txtidvehiculo.Text = string.Format("{0:0000}", Convert.ToInt32(txtidvehiculo.Text));
                        txtnombrevehiculo.Text = validar.NombreVehiculo;
                        txtidconductor.Text = validar.Conductor.IdUsuario.ToString();
                        txtnombreconductor.Text = validar.Conductor.NombreCompleto;
                        txtmarca.Text = validar.Marca;
                        txtidentificacion.Text = validar.Identificacion;
                        txtcargamaxima.Text = Convert.ToDecimal(validar.CargaMaxima).ToString("N2");
                        txtcargaminima.Text = Convert.ToDecimal(validar.CargaManima).ToString("N2");
                        txthoraiodisponibilidad.Text = Convert.ToInt32(validar.HorarioDisponibilidad).ToString("N0");
                        foreach (OpcionCombo oc in cbohabilidad.Items)
                            {
                                if (Convert.ToInt32(oc.IdPos) == Convert.ToInt32(validar.Habilidades.IdHabilidad))
                                {
                                    int indice_combo = cbohabilidad.Items.IndexOf(oc);
                                    cbohabilidad.SelectedIndex = indice_combo;
                                    break;
                                }
                            }
                        foreach (OpcionCombo oc in cboestado.Items)
                            {
                                if (oc.Texto == validar.Habilidades.Descripcion)
                                {
                                    int indice_combo = cboestado.Items.IndexOf(oc);
                                    cboestado.SelectedIndex = indice_combo;
                                    break;
                                }
                            }

                        btneditar.IconChar = IconChar.Ban;
                        btneditar.Text = "Cancelar";
                        btnguardar.Enabled = true;
                        btnadicionar.Enabled = false;
                        btnbuscar.Enabled = false;
                        txtidvehiculo.Enabled = false;
                        txtidvehiculo.BackColor = Color.Khaki;
                    }
                    else
                        MessageBox.Show("Debe seleccionar el vehículo que desea editar", "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion


    }
}
