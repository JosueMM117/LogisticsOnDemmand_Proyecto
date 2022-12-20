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
    public partial class frm_BuscarClientes : Form
    {
        #region Constructor
        public frm_BuscarClientes()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        public CM_Clientes _Clientes = new CM_Clientes();

        #endregion

        #region Eventos
        //Load
        private async void frm_BuscarClientes_Load(object sender, EventArgs e)
        {
            try
            {
                List<CM_Clientes> ListaCientes = await new CN_Clientes().Listar_Clientes();
                //var estado = listaUsuario.Where().FirstOrDefault();
                foreach (CM_Clientes item in ListaCientes)
                {
                    dgv_clientes.Rows.Add(new object[] {
                    item.IdCliente,
                    item.NombreCompleto,
                    item.Direccion,
                    item.Email,
                    item.Telefono,
                    item.Telefono2,
                    item.Estado,
                    item.FechaRegistro,
                    });
                }

                //Filtros
                foreach (DataGridViewColumn columna in dgv_clientes.Columns)
                {
                    if (columna.Visible == true && columna.Name != "IdCliente" && columna.Name != "FechaRegistro")
                    {
                        cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                    }
                }
                cbofiltro.DisplayMember = "Texto";
                cbofiltro.ValueMember = "IdPos";
                //cbofiltro.SelectedIndex = 0;
                txtbusqueda.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        //Click
        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow != 0 || icolumn != 0)
                {
                    _Clientes = new CM_Clientes
                    {
                        IdCliente = Convert.ToInt32(dgv_clientes.Rows[irow].Cells["IdCliente"].Value),
                        NombreCompleto = dgv_clientes.Rows[irow].Cells["NombreCompleto"].Value.ToString(),
                        Email = dgv_clientes.Rows[irow].Cells["Email"].Value.ToString(),
                        Direccion = dgv_clientes.Rows[irow].Cells["Direccion"].Value.ToString(),
                        Telefono = dgv_clientes.Rows[irow].Cells["Telefono"].Value.ToString(),
                        Telefono2 = dgv_clientes.Rows[irow].Cells["Telefono2"].Value.ToString(),
                        Estado = dgv_clientes.Rows[irow].Cells["Estado"].Value.ToString(),
                        FechaRegistro = dgv_clientes.Rows[irow].Cells["FechaRegistro"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (dgv_clientes.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgv_clientes.Rows)
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
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
