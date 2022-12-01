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
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
