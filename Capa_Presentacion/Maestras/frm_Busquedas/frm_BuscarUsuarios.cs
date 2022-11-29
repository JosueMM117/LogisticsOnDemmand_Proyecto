using LogisticsOnDemmand_Proyecto.Capa_Modelo;
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
    public partial class frm_BuscarUsuarios : Form
    {
        public CM_Usuarios _Usuarios { get; set; }
        public frm_BuscarUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Usuarios = new CM_Usuarios()
            {
                IdUsuario = 1,
                NombreCompleto = "Josue Moscoso",
                Estado = "Activo"
            };
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
