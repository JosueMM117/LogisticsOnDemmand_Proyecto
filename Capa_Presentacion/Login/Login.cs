using Firebase.Auth;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Negocio;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login
{
    public partial class Login : Form
    {
        private CN_Usuarios cdusaurios = new CN_Usuarios();
        public Login()
        {
            InitializeComponent();
            txtemail.Focus();
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar= true;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form oprenform = Application.OpenForms["Registro"];
            if (oprenform != null)
            {
                oprenform.WindowState = FormWindowState.Normal;
                oprenform.TopMost = true;
                oprenform.ShowDialog();
            }
            else
            {
                Form open = new Registro();
                open.ShowDialog();
            }
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //List<CM_Usuarios> listausuario = await cdusaurios.Listar_Usuarios();
                //var validar = listausuario.Select(b => b.Estado == false).FirstOrDefault();
                //if (validar == true)
                //{
                //    MessageBox.Show("El usuario " + txtemail.Text + " se encuentra inactivo o no existe.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                    //validar = listausuario.Select(b => b.Email == txtemail.Text && b.Clave == txtclave.Text).FirstOrDefault();
                    //if (validar == false)
                    //{
                        var objusuario = new CM_Usuarios()
                        {
                            Email = txtemail.Text,
                            Clave = txtclave.Text
                        };
                        //var autenticacion = new FirebaseAuthProvider(new FirebaseConfig(CD_ConexionFireBase.WebApiKey));
                        //var authuser = await autenticacion.SignInWithEmailAndPasswordAsync(objusuario.Email.ToString(), txtclave.Text.ToString());
                        //string obternertoken = authuser.FirebaseToken;
                        Inicio frm_inicio = new Inicio(objusuario);
                        frm_inicio.Show();
                        this.Hide();
                        frm_inicio.FormClosing += Login_Closing;
                    //}
                    //else
                    //    MessageBox.Show("El Usuario o contraseña son incorrecto", "Inicio de Seción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void Login_Closing(object sender, FormClosingEventArgs e)
        {
            txtemail.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
