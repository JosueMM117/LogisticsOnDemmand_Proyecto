﻿using FontAwesome.Sharp;
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

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Habilidades : Form
    {
        public CN_Vehiculos cnvehiculos = new CN_Vehiculos();
        #region Constructor
        public frm_Habilidades()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public void Limpiar()
        {
            txtidhabilidad.Select();
            txtidhabilidad.Clear();
            txtdescripcion.Clear();
            cboestado.SelectedIndex = -1;
        }
        public void CargarDatos()
        {
            try
            {
                //Estado
                List<OpcionCombo> listaestado = new List<OpcionCombo>
                {
                    new OpcionCombo() { IdPos = 0, Texto = "Activo" },
                    new OpcionCombo() { IdPos = 1, Texto = "Inactivo" }
                };
                foreach (OpcionCombo estados in listaestado)
                {
                    cboestado.Items.Add(new OpcionCombo() { IdPos = estados.IdPos, Texto = estados.Texto });
                }
                cboestado.DisplayMember = "Texto";
                cboestado.ValueMember = "IdPos";
                cboestado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos

        //Load
        private void frm_Habilidades_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
            txtidhabilidad.Select();
            CargarDatos();
        }

        //Click
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
                    txtidhabilidad.Enabled = true;
                    txtidhabilidad.BackColor = Color.White;
                    Limpiar();
                }
                else
                {
                    btnadicionar.IconChar = IconChar.Ban;
                    btnadicionar.Text = "Cancelar";
                    btneditar.Enabled = false;
                    btnbuscar.Enabled = false;
                    txtidhabilidad.Enabled = false;
                    cboestado.Enabled = false;
                    Limpiar();
                    List<CM_Habilidades> BuscarDatos = await cnvehiculos.Listar_Habilidades();
                    int cant_registros = BuscarDatos.Select(b => b.IdHabilidad).Count();
                    int idgenerado;

                    if (cant_registros == 0)
                        idgenerado = 1;
                    else
                    {
                        cant_registros = BuscarDatos.Select(b => b.IdHabilidad).Max();
                        idgenerado = cant_registros + 1;
                    }
                    txtidhabilidad.Text = string.Format("{0:000}", idgenerado);
                    txtidhabilidad.BackColor = Color.LightGreen;
                    btnguardar.Enabled = true;
                    cboestado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                var objhabilidad = new CM_Habilidades()
                {
                    IdHabilidad = Convert.ToInt32(txtidhabilidad.Text),
                    Descripcion = txtdescripcion.Text,
                    Estado = cboestado.GetItemText(cboestado.SelectedItem),
                    FechaRegistro = Convert.ToDateTime(DateTime.Now.Date.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };

                bool respuesta = cnvehiculos.Registrar_Habilidad(objhabilidad, out mensaje);
                if (respuesta == true)
                {
                    btnadicionar.IconChar = IconChar.Plus;
                    btnadicionar.Text = "Adicionar";
                    btneditar.IconChar = IconChar.PenToSquare;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btneditar.Enabled = true;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    txtidhabilidad.Enabled = true;
                    cboestado.Enabled = true;
                    txtidhabilidad.BackColor = Color.White;
                }
                else
                    MessageBox.Show(mensaje, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                List<CM_Habilidades> BuscarDatos = await cnvehiculos.Listar_Habilidades();
                var validar = BuscarDatos.Where(b => b.IdHabilidad == Convert.ToInt32(txtidhabilidad.Text)).FirstOrDefault();
                if (btneditar.IconChar == IconChar.Ban)
                {
                    btneditar.IconChar = IconChar.PenToSquare;
                    btneditar.Text = "Editar";
                    btnguardar.Enabled = false;
                    btnadicionar.Enabled = true;
                    btnbuscar.Enabled = true;
                    txtidhabilidad.Enabled = true;
                    txtidhabilidad.BackColor = Color.White;

                    #region Cargar_Datos_IdSelecciado
                    txtidhabilidad.Text = string.Format("{0:000}", Convert.ToInt32(txtidhabilidad.Text));
                    txtdescripcion.Text = validar.Descripcion;
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (oc.Texto == validar.Descripcion)
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
                        txtidhabilidad.Text = string.Format("{0:000}", Convert.ToInt32(txtidhabilidad.Text));
                        txtdescripcion.Text = validar.Descripcion;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Descripcion)
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
                        txtidhabilidad.Enabled = false;
                        txtidhabilidad.BackColor = Color.Khaki;
                    }
                    else
                        MessageBox.Show("Debe seleccionar la habilidad que desea editar", "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["frm_BuscarHabilidades"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new frm_BuscarHabilidades();
                open.ShowDialog();
            }
        }
        //KeyPress
        private void txtidhabilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarKeyPress.Numeros(e);
        }
        private async void txtidhabilidad_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    e.SuppressKeyPress = true;
                    int codigo = int.Parse(txtidhabilidad.Text);
                    List<CM_Habilidades> BuscarDatos = await cnvehiculos.Listar_Habilidades();
                    var validar = BuscarDatos.Where(b => b.IdHabilidad == Convert.ToInt32(txtidhabilidad.Text)).FirstOrDefault();
                    if (validar != null)
                    {
                        e.SuppressKeyPress = true;
                        txtidhabilidad.Text = string.Format("{0:000}", codigo);
                        txtdescripcion.Text = validar.Descripcion;
                        foreach (OpcionCombo oc in cboestado.Items)
                        {
                            if (oc.Texto == validar.Estado)
                            {
                                int indice_combo = cboestado.Items.IndexOf(oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                        txtidhabilidad.SelectionStart = txtidhabilidad.MaxLength;
                    }
                    else
                    {
                        MessageBox.Show("El Producto no existe", "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtidhabilidad.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
