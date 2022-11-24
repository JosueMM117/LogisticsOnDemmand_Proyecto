using FontAwesome.Sharp;
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
    public partial class frm_Usuarios : Form
    {
        private static Form FormularioActivo = new Form();
        public frm_Usuarios()
        {
            InitializeComponent();
        }


        #region Metodos
        public void AbrirNuevoNodo(Form formulariohijo)
        {
            FormularioActivo = formulariohijo;
            formulariohijo.TopLevel = true;
            formulariohijo.StartPosition = FormStartPosition.CenterScreen;
            formulariohijo.FormBorderStyle = FormBorderStyle.Sizable;
            formulariohijo.WindowState = FormWindowState.Normal;
            formulariohijo.Show();
            //formulariohijo = Application.OpenForms["frm_Usuarios"];
            //if (formulariohijo != null)
            //{
            //    //openform.TopLevel = false;
                
            //}
            //else
            //{
            //    formulariohijo.StartPosition = FormStartPosition.CenterScreen;
            //    formulariohijo.FormBorderStyle = FormBorderStyle.Sizable;
            //    formulariohijo.WindowState = FormWindowState.Normal;
            //    formulariohijo.Show();
            //}
        }
        #endregion
        private void btnrutas_Click(object sender, EventArgs e)
        {
            AbrirNuevoNodo(new frm_Usuarios());
        }
    }
}
