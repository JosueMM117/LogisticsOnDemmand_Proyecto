using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using FontAwesome.Sharp;
using LogisticsOnDemmand_Proyecto.Capa_Modelo;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Login;
using LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras;
using LogisticsOnDemmand_Proyecto.Utility_Class;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Menus
{
    public partial class Inicio : Form
    {
        #region Atributos
        private static IconButton MenuActivo = null;
        private Form FormularioActivo = null;
        private IconButton currentbtn;
        private Panel leftBorderbtn;
        public static CM_Usuarios usuariologueado;

        #endregion

        #region Constructor
        public Inicio(CM_Usuarios objusuario)
        {
            usuariologueado = objusuario;
            InitializeComponent();
            txtemail.Text = usuariologueado.Email.ToString();
            txtnombrecompleto.Text = usuariologueado.NombreCompleto.ToString();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7,60);
            pnlcontenedormenu.Controls.Add(leftBorderbtn);
        }

        #endregion

        #region Metodos

        #region Otros metodos
        private void ActivarAnimacion_BotonesMenu(object senderbtn, Color colorfondo)
        {
            if (senderbtn!=null)
            {
                DesactivarAnimacion_BotonesManu();

                //Boton
                currentbtn = (IconButton)senderbtn;
                currentbtn.BackColor = Color.FromArgb(25,25,25);
                currentbtn.ForeColor = colorfondo;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = colorfondo;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign= ContentAlignment.MiddleRight;

                //Borde del boton a la izquierda
                leftBorderbtn.BackColor = colorfondo;
                leftBorderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
                    
                
            }
        }
        private void DesactivarAnimacion_BotonesManu()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(25, 25, 25);
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.FromArgb(30, 144, 255);
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ReiniciarAnimaciones()
        {
            try
            {
                DesactivarAnimacion_BotonesManu();
                leftBorderbtn.Visible = false;
                iconformhijo.IconChar = IconChar.Home;
                iconformhijo.IconColor = Color.FromArgb(30, 144, 255);
                lbltituloformhijo.Text = "Inicio";
                pnlcontenedor.Controls.Clear();
                FormularioActivo.Close();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            
        }
        private void AbrirFormulario(Form formulariohijo)
        {
            FormularioActivo = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle= FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            pnlcontenedor.Controls.Add(formulariohijo);
            pnlcontenedor.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }
        //private void AbrirFormularios<T>() where T : Form, new()
        //{
        //    Form formulario = pnlcontenedor.Controls.OfType<T>().FirstOrDefault();
        //    if (formulario != null)
        //    {
        //        //Si la instancia esta minimizada la dejamos en su estado normal
        //        if (formulario.WindowState == FormWindowState.Normal)
        //        {
        //            formulario.WindowState = FormWindowState.Maximized;
        //        }
        //    //Si la instancia existe la pongo en primer plano
        //    formulario.BringToFront();
        //        return;
        //    }
        //    //Se abre el form
        //    formulario = new T();
        //    formulario.TopLevel = false;
        //    pnlcontenedor.Controls.Add(formulario);
        //    //pnlcontenedor.Tag = formulario;
        //    formulario.Show();
        //}
        #endregion

        #endregion

        #region Eventos

        #region Mouse
        //Activar la animacion botones
        private void btnrutas_MouseMove(object sender, MouseEventArgs e)
        {
            ActivarAnimacion_BotonesMenu(sender, Estructuras_Colores.color7);
        }
        //Desactivar la animacion botones
        private void btnrutas_MouseLeave(object sender, EventArgs e)
        {
            DesactivarAnimacion_BotonesManu();
        }

        #endregion

        #region Click
        //botones
        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnrutas_Click(object sender, EventArgs e)
        {
            //Icono del form hijo actual
            iconformhijo.IconChar = currentbtn.IconChar;
            iconformhijo.IconColor = currentbtn.IconColor;
            lbltituloformhijo.Text = currentbtn.Text;

            AbrirFormulario(new frm_Rutas());
            //AbrirFormulario((IconButton)sender, new frm_Rutas());
            //Form openform = Application.OpenForms["frm_Rutas"];
            //if (openform != null)
            //{
            //    openform.TopLevel = false;
            //    pnlcontenedor.Controls.Add(openform);
            //    //openform.WindowState = FormWindowState.Normal;
            //    openform.Show();
            //}
            //else
            //{
            //    Form open = new frm_Rutas();
            //    open.TopLevel = false;
            //    pnlcontenedor.Controls.Add(open);
            //    open.Show();
            //}
        }
        private void btnusuarios_Click(object sender, EventArgs e)
        {
            //Icono del form hijo actual
            iconformhijo.IconChar = currentbtn.IconChar;
            iconformhijo.IconColor = currentbtn.IconColor;
            lbltituloformhijo.Text = currentbtn.Text;

            AbrirFormulario(new frm_Usuarios());
            //Form openform = Application.OpenForms["frm_Usuarios"];
            //if (openform != null)
            //{
            //    openform.TopLevel = false;
            //    pnlcontenedor.Controls.Add(openform);
            //    //openform.WindowState = FormWindowState.Normal;
            //    openform.Show();
            //}
            //else
            //{
            //    Form open = new frm_Usuarios();
            //    open.TopLevel = false;
            //    pnlcontenedor.Controls.Add(open);
            //    open.Show();
            //}
        }
        private void btnvehiculos_Click(object sender, EventArgs e)
        {
            //Icono del form hijo actual
            iconformhijo.IconChar = currentbtn.IconChar;
            iconformhijo.IconColor = currentbtn.IconColor;
            lbltituloformhijo.Text = currentbtn.Text;

            AbrirFormulario(new frm_Vehiculos());
            //Form openform = Application.OpenForms["frm_Vehiculos"];
            //if (openform != null)
            //{
            //    openform.WindowState = FormWindowState.Normal;
            //    openform.Show();
            //}
            //else
            //{
            //    Form open = new frm_Vehiculos();
            //    open.Show();
            //}
        }
        private void btnajustes_Click(object sender, EventArgs e)
        {
            //Icono del form hijo actual
            iconformhijo.IconChar = currentbtn.IconChar;
            iconformhijo.IconColor = currentbtn.IconColor;
            lbltituloformhijo.Text = currentbtn.Text;

            AbrirFormulario(new frm_Ajustes());

            //Form openform = Application.OpenForms["frm_Ajustes"];
            //if (openform != null)
            //{
            //    openform.WindowState = FormWindowState.Normal;
            //    openform.Show();
            //}
            //else
            //{
            //    Form open = new frm_Ajustes();
            //    open.Show();
            //}
        }
        private void iconformhijo_Click(object sender, EventArgs e)
        {
            ReiniciarAnimaciones();
            
        }

        #endregion

        #endregion

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
