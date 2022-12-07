using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Utility_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas
{
    public partial class frm_BuscarVehiculos : Form
    {
        public CN_Vehiculos cnvehiculos = new CN_Vehiculos();
        public CM_Vehiculos _Vehiculos = new CM_Vehiculos();
        #region Constructor
        public frm_BuscarVehiculos()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        #endregion

        #region Eventos
        //Load
        private async void frm_BuscarVehiculos_Load(object sender, EventArgs e)
        {
            List<CM_Vehiculos> ListaVehiculos = await cnvehiculos.Listar_Vehículos();
            //var estado = listaUsuario.Where().FirstOrDefault();
            foreach (CM_Vehiculos item in ListaVehiculos)
            {
                dgv_vehiculos.Rows.Add(new object[] {
                    item.IdVehiculo,
                    item.NombreVehiculo,
                    item.Marca,
                    item.CargaMaxima,
                    item.CargaMinima,
                    item.Identificacion,
                    item.HorarioDisponibilidad,
                    item.Conductor.IdUsuario,
                    item.Conductor.NombreCompleto,
                    item.Habilidades.IdHabilidad,
                    string.Format("{0:000}"+"-"+item.Habilidades.Descripcion, item.Habilidades.IdHabilidad),
                    item.Estado,
                    item.FechaRegistro.ToString("dd-MMM-yyy"),
                    });
            }

            //Filtros
            foreach (DataGridViewColumn columna in dgv_vehiculos.Columns)
            {
                if (columna.Visible == true && columna.Name != "IdVehiculo" && columna.Name != "FechaRegistro")
                {
                    cbofiltro.Items.Add(new OpcionCombo() { IdPos = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbofiltro.DisplayMember = "Texto";
            cbofiltro.ValueMember = "IdPos";
            //cbofiltro.SelectedIndex = 0;
            txtbusqueda.Select();
        }

        //Click
        private void dgv_vehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int irow = e.RowIndex;
                int icolumn = e.ColumnIndex;
                if (irow != 0 || icolumn != 0)
                {
                    _Vehiculos = new CM_Vehiculos
                    {
                        IdVehiculo = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["IdVehiculo"].Value),
                        NombreVehiculo = dgv_vehiculos.Rows[irow].Cells["NombreVehiculo"].Value.ToString(),
                        Marca = dgv_vehiculos.Rows[irow].Cells["Marca"].Value.ToString(),
                        CargaMaxima = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["CargaMax"].Value),
                        CargaMinima = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["CargaMin"].Value),
                        Identificacion = dgv_vehiculos.Rows[irow].Cells["Identificacion"].Value.ToString(),
                        HorarioDisponibilidad = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["HorarioDisponibilidad"].Value),
                        Conductor = new CM_Usuarios
                        {
                            IdUsuario = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["IdUsuario"].Value),
                            NombreCompleto = dgv_vehiculos.Rows[irow].Cells["NombreConductor"].Value.ToString()
                        },
                        Habilidades = new CM_Habilidades
                        {
                            IdHabilidad = Convert.ToInt32(dgv_vehiculos.Rows[irow].Cells["IdHabilidad"].Value),
                            Descripcion = dgv_vehiculos.Rows[irow].Cells["DescripcionHabilidad"].Value.ToString()
                        },
                        Estado = dgv_vehiculos.Rows[irow].Cells["Estado"].Value.ToString(),
                        FechaRegistro = Convert.ToDateTime(dgv_vehiculos.Rows[irow].Cells["FechaRegistro"].Value)
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
                    if (dgv_vehiculos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgv_vehiculos.Rows)
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
