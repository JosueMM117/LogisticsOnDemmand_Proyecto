using LogisticsOnDemmand_Proyecto.Capa_Datos;
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
    public partial class frm_BuscarRutas : Form
    {
        public CN_Rutas cn_rutas = new CN_Rutas();
        public CM_Rutas _Ruta = new CM_Rutas();
        #region Constructor
        public frm_BuscarRutas()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        #endregion

        #region Eventos
        //Load
        private async void frm_BuscarRutas_Load(object sender, EventArgs e)
        {
            List<CM_Rutas> ListaRutas = await cn_rutas.Listar_Rutas();
            //var estado = listaUsuario.Where().FirstOrDefault();
            foreach (CM_Rutas item in ListaRutas)
            {
                dgv_rutas.Rows.Add(new object[] {
                    string.Format("{0:0000}",item.IdRuta),
                    item.Titulo,
                    item.Concepto,
                    string.Format("{0:dd-MMM-yyy}",item.Fecha_Entrega),
                    item.Tiempo_Ruta,
                    item.Cargas,
                    item.Comentarios,
                    item.Prioridad,
                    item.Estado,
                    string.Format("{0:dd-MMM-yyy}",item.FechaRegistro)
                });
            }

            //Filtros
            foreach (DataGridViewColumn columna in dgv_rutas.Columns)
            {
                if (columna.Visible == true && columna.Name != "IdRuta" && columna.Name != "FechaRegistro")
                {
                    cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbofiltro.DisplayMember = "Texto";
            cbofiltro.ValueMember = "IdPos";
            txtbusqueda.Select();
        }
        #region Click
        //CellDoubleClick
        private void dgv_rutas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow != 0 || icolumn != 0)
                {
                    _Ruta = new CM_Rutas
                    {
                        IdRuta = Convert.ToInt32(dgv_rutas.Rows[irow].Cells["IdRuta"].Value),
                        Titulo = dgv_rutas.Rows[irow].Cells["Titulo"].Value.ToString(),
                        Concepto = dgv_rutas.Rows[irow].Cells["Concepto"].Value.ToString(),
                        Fecha_Entrega = Convert.ToDateTime(dgv_rutas.Rows[irow].Cells["FechaEntrega"].Value),
                        Tiempo_Ruta = dgv_rutas.Rows[irow].Cells["TiempoRuta"].Value.ToString(),
                        Cargas = Convert.ToInt32(dgv_rutas.Rows[irow].Cells["Cargas"].Value),
                        Comentarios = dgv_rutas.Rows[irow].Cells["Comentarios"].Value.ToString(),
                        Prioridad = dgv_rutas.Rows[irow].Cells["Prioridad"].Value.ToString(),
                        Estado = dgv_rutas.Rows[irow].Cells["Estado"].Value.ToString(),
                        FechaRegistro = Convert.ToDateTime(dgv_rutas.Rows[irow].Cells["FechaRegistro"].Value)
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (dgv_rutas.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgv_rutas.Rows)
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
                MessageBox.Show(ex.Message, "Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion


    }
}
