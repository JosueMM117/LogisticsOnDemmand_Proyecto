using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
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

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas
{
    public partial class frm_BuscarUsuarios : Form
    {
        public CM_Usuarios _Usuarios { get; set; }
        public CN_Usuarios cnusuarios = new CN_Usuarios();

        #region Constructor
        public frm_BuscarUsuarios()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        //Load
        private async void frm_BuscarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                List<CM_Usuarios> ListaUsuarios = await cnusuarios.Listar_Usuarios();
                //var usuarios = ListaUsuarios.Where(b=>b.Rol == "Conductor" && b.Estado == "Activo").FirstOrDefault();
                foreach (CM_Usuarios item in ListaUsuarios.Where(b => b.Rol == "Conductor" && b.Estado == "Activo"))
                {
                    dgvusuarios.Rows.Add(new object[] {
                    item.IdUsuario,
                    item.NombreCompleto,
                    item.Rol,
                    item.Email,
                    item.Telefono,
                    item.Estado,
                    item.FechaRegistro.ToString("dd-MMM-yyy"),
                });
                }

                //Filtros
                foreach (DataGridViewColumn columna in dgvusuarios.Columns)
                {
                    if (columna.Visible == true && columna.Name != "IdUsuario" && columna.Name != "FechaRegistro")
                    {
                        cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                    }
                }
                cbofiltro.DisplayMember = "Texto";
                cbofiltro.ValueMember = "IdPos";
                cbofiltro.SelectedIndex = 0;
                txtbusqueda.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Click
        private void dgvusuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow != 0 || icolumn != 0)
                {
                    _Usuarios = new CM_Usuarios
                    {
                        IdUsuario = Convert.ToInt32(dgvusuarios.Rows[irow].Cells["IdUsuario"].Value),
                        NombreCompleto = dgvusuarios.Rows[irow].Cells["NombreCompleto"].Value.ToString(),
                        Estado = dgvusuarios.Rows[irow].Cells["Estado"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnexportarexcel_Click(object sender, EventArgs e)
        {

        }

        //KeyPress
        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show(ex.Message, "Vehículos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion 
    }
}
