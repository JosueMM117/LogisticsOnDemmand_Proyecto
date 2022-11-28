using Firebase.Auth;
using FontAwesome.Sharp;
using LiteDB;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
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
using System.Windows.Media.Media3D;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    public partial class frm_Usuarios : Form
    {
        private static List<CM_Usuarios> listausuarios;
        private CN_Usuarios cdusaurios = new CN_Usuarios();

        #region Constructor
        public frm_Usuarios()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        public async void CargarDatos()
        {
            try
            {
                //Roles
                List<OpcionCombo> listaroles = new List<OpcionCombo>
                {
                    new OpcionCombo() { IdPos = 0, Texto = "Conductor" },
                    new OpcionCombo() { IdPos = 1, Texto = "Copiloto" },
                    new OpcionCombo() { IdPos = 2, Texto = "Soporte Técnico" },
                };
                foreach (OpcionCombo roles in listaroles)
                {
                    cborol.Items.Add(new OpcionCombo() { IdPos = roles.IdPos, Texto = roles.Texto });
                }
                cborol.DisplayMember = "Texto";
                cborol.ValueMember = "IdPos";
                cborol.SelectedIndex = -1;

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
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<CM_Usuarios> listaUsuario = await new CN_Usuarios().Listar_Usuarios();
            //var estado = listaUsuario.Where().FirstOrDefault();
            foreach (CM_Usuarios item in listaUsuario)
            {
                dgvusuarios.Rows.Add(new object[] {
                    "",
                    item.IdUsuario,
                    item.NombreCompleto,
                    item.Rol,
                    item.Email,
                    item.Telefono,
                    item.Estado,
                    item.FechaRegistro.ToString("dd-MMM-yyy"),
                    });
            }
        }
        #endregion

        #region Eventos
        //Load
        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                txtnombrecompleto.Enabled = false;
                txttelefono.Enabled = false;
                txtemail.Enabled = false;
                cborol.Enabled = false;
                cboestado.Enabled = false;
                btncancelar.Enabled = false;
                btnguardarcambios.Enabled = false;
                foreach (DataGridViewColumn columna in dgvusuarios.Columns)
                {
                    if (columna.Visible == true && columna.Name != "btnseleccionar")
                    {
                        cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                    }
                }
                cbofiltro.DisplayMember = "Texto";
                cbofiltro.ValueMember = "Valor";
                cbofiltro.SelectedIndex = 0;
                CargarDatos();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Click
        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolumn = e.ColumnIndex;
            try
            {
                if (irow >= 0 && icolumn >= 0)
                {
                    txtidusuario.Text = Convert.ToString(dgvusuarios.Rows[irow].Cells["IdUsuario"].Value.ToString());
                    txtnombrecompleto.Text = dgvusuarios.Rows[irow].Cells["NombreCompleto"].Value.ToString();
                    txtemail.Text = dgvusuarios.Rows[irow].Cells["Email"].Value.ToString();
                    txttelefono.Text = dgvusuarios.Rows[irow].Cells["Telefono"].Value.ToString();
                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (oc.Texto == dgvusuarios.Rows[irow].Cells["Rol"].Value.ToString())
                        {
                            int indice = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (oc.Texto == dgvusuarios.Rows[irow].Cells["Estado"].Value.ToString())
                        {
                            int indice = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice;
                            break;
                        }
                    }

                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnadiconar_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["Registro"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new Registro();
                open.ShowDialog();
            }
        }
        private async void btnguardarcambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombrecompleto.Text))
                {
                    MessageBox.Show("No se puede dejar el campo *Nombre Completo* en blanco.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //Crear validacion para inactivar el usuarios, 
                //si un usuario aun tiene rutas pendientes por completar,
                //debe indicar que no se puede inactivar dicho usuario
                object objrol = cborol.SelectedItem;
                string rol = cborol.GetItemText(objrol);
                object objestado = cboestado.SelectedItem;
                string estado = cboestado.GetItemText(objestado);

                var objusuario = new CM_Usuarios()
                {
                    IdUsuario = Convert.ToInt32(txtidusuario.Text),
                    NombreCompleto = txtnombrecompleto.Text,
                    Email = txtemail.Text,
                    Telefono = txttelefono.Text,
                    Rol = rol,
                    Estado = estado,
                    FechaRegistro = Convert.ToDateTime(DateTime.Now.Date.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };

                bool respuesta = await cdusaurios.Actualizar_InformacionUsuarios(objusuario);
                if (respuesta == true)
                {
                    txtnombrecompleto.Enabled = false;
                    txttelefono.Enabled = false;
                    txtemail.Enabled = false;
                    cborol.Enabled = false;
                    cboestado.Enabled = false;
                    btnadicionar.Enabled = true;
                    btneditar.Enabled = true;
                    btnguardarcambios.Enabled = false;
                    btncancelar.Enabled = false;
                    dgvusuarios.Rows.Clear();
                    cboestado.Items.Clear();
                    cborol.Items.Clear();
                    await Task.Delay(500);
                    CargarDatos();
                    MessageBox.Show("Datos actualizados.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            txtnombrecompleto.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
            cborol.Enabled = true;
            cboestado.Enabled = true;
            btnadicionar.Enabled = false;
            btneditar.Enabled = false;
            btnguardarcambios.Enabled = true;
            btncancelar.Enabled = true;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnombrecompleto.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            cborol.Enabled = false;
            cboestado.Enabled = false;
            btnadicionar.Enabled = true;
            btneditar.Enabled = true;
            btnguardarcambios.Enabled = false;
            btncancelar.Enabled = false;
        }
        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string columnafiltro = ((OpcionCombo)cbofiltro.SelectedItem).IdPos.ToString();
                if (string.IsNullOrEmpty(columnafiltro))
                {
                    return;
                }
                else
                {
                    if (dgvusuarios.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvusuarios.Rows)
                        {
                            if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                                row.Visible = true;
                            else
                                row.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void btnquitarfiltro_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = string.Empty;
            foreach (DataGridViewRow irow in dgvusuarios.Rows)
            {
                irow.Visible = true;
            }
        }
        #endregion


    }
}
