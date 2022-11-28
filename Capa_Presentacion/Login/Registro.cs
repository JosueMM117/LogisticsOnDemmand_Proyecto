using Firebase.Auth;
using LogisticsOnDemmand_Proyecto.Capa_Datos;
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

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login
{
    public partial class Registro : Form
    {
        public CN_Usuarios cnusuario = new CN_Usuarios();
        public Registro()
        {
            InitializeComponent();
            txtnombrecompleto.Select();
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            txtclave.UseSystemPasswordChar = true;
        }

        private void txtconfirmarclave_TextChanged(object sender, EventArgs e)
        {
            txtconfirmarclave.UseSystemPasswordChar = true;
        }

        private async void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                if (!txtclave.Text.Trim().Equals(txtconfirmarclave.Text))
                {
                    MessageBox.Show("Las contraseñas introducidas no coinciden.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<CM_Usuarios> BuscarDatos = await cnusuario.Listar_Usuarios();
                int cant_registros = BuscarDatos.Select(b => b.IdUsuario).Count();
                int idgenerado;
                if (cant_registros == 0)
                    idgenerado = 1;
                else
                {
                    cant_registros = BuscarDatos.Select(b => b.IdUsuario).Max();
                    idgenerado = cant_registros + 1;
                }
                var objusuario = new CM_Usuarios()
                {
                    IdUsuario = idgenerado,
                    NombreCompleto = txtnombrecompleto.Text,
                    Email = txtemail.Text,
                    Clave = txtclave.Text,
                    Rol  = "Soporte Técnico",
                    Telefono = "",
                    Estado = "Activo",
                    FechaRegistro = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyy HH:mm:ss tt"))
                };
                if (txtclave.Text.Length < 6)
                {
                    MessageBox.Show("La contraseña debe contener un minimo de al menos 6 caracteres.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var respuesta = cnusuario.Registrar_Usuario(objusuario, out mensaje);
                    if (respuesta == true)
                    {
                        await CrearUsuarioProveedor(txtemail.Text, txtclave.Text);
                        btnregistrar.Enabled = false;
                        await Task.Delay(3000);
                        btnregistrar.Enabled = true;
                        MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CrearUsuarioProveedor(string txtemail, string txtclave)
        {
            try
            {
                var Autenticacion = new FirebaseAuthProvider(new FirebaseConfig(CD_ConexionFireBase.WebApiKey));
                await Autenticacion.CreateUserWithEmailAndPasswordAsync(txtemail.ToString(), txtclave.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
