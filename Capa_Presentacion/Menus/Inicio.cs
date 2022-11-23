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
using LogisticsOnDemmand_Proyecto.Utility_Class;

namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Menus
{
    public partial class Inicio : Form
    {
        #region Atributos
        private IconButton currentbtn;
        private Panel leftBorderbtn;
        public static CM_Usuarios usuariologueado;
        #endregion

        #region Constructor
        public Inicio(CM_Usuarios objusuario)
        {
            usuariologueado = objusuario;
            InitializeComponent();
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
                currentbtn.IconColor = Color.FromArgb(30, 144, 255); ;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
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
        #endregion

        #endregion


    }
}
