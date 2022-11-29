using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
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
    public partial class frm_Vehiculos : Form
    {
        public frm_Vehiculos()
        {
            InitializeComponent();
        }

        private void btnhabilidad_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["frm_Habilidades"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new frm_Habilidades();
                open.ShowDialog();
            }
        }

        private void btnbuscarconductor_Click(object sender, EventArgs e)
        {

        }
    }
}
