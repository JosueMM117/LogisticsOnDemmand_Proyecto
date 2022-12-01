using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
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
                //dgvhabilidades.Columns.RemoveAt(-1);
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
                    //MessageBox.Show("Has seleccionado una celda", "Habilidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
