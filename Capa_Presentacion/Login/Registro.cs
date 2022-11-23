using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = true;
        }

        private void txtconfirmarclave_TextChanged(object sender, EventArgs e)
        {
            txtconfirmarclave.UseSystemPasswordChar = true;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
