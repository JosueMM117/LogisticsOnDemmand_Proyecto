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
    public partial class frm_BuscarHabilidades : Form
    {
        public CN_Vehiculos cnvehiculos = new CN_Vehiculos();
        public CM_Habilidades _Habilidades = new CM_Habilidades();
        #region Constructor
        public frm_BuscarHabilidades()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        //Load
        private async void frm_BuscarHabilidades_Load(object sender, EventArgs e)
        {
            try
            {

                List<CM_Habilidades> ListaHabilidades = await cnvehiculos.Listar_Habilidades();
                //var estado = listaUsuario.Where().FirstOrDefault();
                foreach (CM_Habilidades item in ListaHabilidades)
                {
                    dgvhabilidades.Rows.Add(new object[] {
                    item.IdHabilidad,
                    item.Descripcion,
                    item.Estado,
                    item.FechaRegistro.ToString("dd-MMM-yyy"),
                    });
                }

                //Filtros
                foreach (DataGridViewColumn columna in dgvhabilidades.Columns)
                {
                    if (columna.Visible == true && columna.Name != "IdHabilidad" && columna.Name != "FechaRegistro")
                    {
                        cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                    }
                }
                cbofiltro.DisplayMember = "Texto";
                cbofiltro.ValueMember = "IdPos";
                cbofiltro.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Click
        private void dgvhabilidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow != 0 || icolumn != 0)
                {
                    _Habilidades = new CM_Habilidades
                    {
                        IdHabilidad = Convert.ToInt32(dgvhabilidades.Rows[irow].Cells["IdHabilidad"].Value),
                        Descripcion = dgvhabilidades.Rows[irow].Cells["Descripcion"].Value.ToString(),
                        Estado = dgvhabilidades.Rows[irow].Cells["Estado"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //MessageBox.Show("Has seleccionado una celda", "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnquitarfiltro_Click(object sender, EventArgs e)
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
                    if (dgvhabilidades.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvhabilidades.Rows)
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
                MessageBox.Show(ex.Message, "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
