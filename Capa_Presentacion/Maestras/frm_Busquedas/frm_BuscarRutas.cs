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
        private void frm_BuscarRutas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        #region Click

        #endregion

        #endregion

    }
}
