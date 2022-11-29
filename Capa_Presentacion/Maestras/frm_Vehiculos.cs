using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas;
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

        #region Eventos

        //Click
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
            using (var new_modal = new frm_BuscarUsuarios())
            {
                var resultado = new_modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    if (new_modal._Usuarios.Estado == "Activo")
                    {
                        txtidconductor.Text = new_modal._Usuarios.IdUsuario.ToString();
                        txtnombreconductor.Text = new_modal._Usuarios.NombreCompleto;
                    }
                    else
                        MessageBox.Show("El conductor se encuentra inactivo.","Vehiculos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Form oprenform = Application.OpenForms["frm_Habilidades"];
            //if (oprenform != null)
            //{
            //    oprenform.WindowState = FormWindowState.Normal;
            //    oprenform.TopMost = true;
            //    oprenform.ShowDialog();
            //}
            //else
            //{
            //    Form open = new frm_Habilidades();
            //    open.ShowDialog();
            //}
        }
        #endregion

    }
}
