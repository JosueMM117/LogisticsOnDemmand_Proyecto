namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas
{
    partial class frm_BuscarRutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuscarRutas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_rutas = new MetroFramework.Controls.MetroGrid();
            this.btnquitarfiltro = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbofiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menubotones = new System.Windows.Forms.MenuStrip();
            this.btnexportarexcel = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentanaTiempoDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentanaTiempoHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutas)).BeginInit();
            this.menubotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgv_rutas);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 629);
            this.panel2.TabIndex = 6;
            // 
            // dgv_rutas
            // 
            this.dgv_rutas.AllowUserToAddRows = false;
            this.dgv_rutas.AllowUserToDeleteRows = false;
            this.dgv_rutas.AllowUserToResizeRows = false;
            this.dgv_rutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rutas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_rutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_rutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_rutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRuta,
            this.Titulo,
            this.Concepto,
            this.Direccion,
            this.FechaEntrega,
            this.VentanaTiempoDesde,
            this.VentanaTiempoHasta,
            this.Cargas,
            this.IdVehiculo,
            this.NombreVehiculo,
            this.NombreCliente,
            this.TelefonoCliente,
            this.Telefono2Cliente,
            this.EmailCliente,
            this.Comentarios,
            this.Prioridad,
            this.Estado,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rutas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rutas.EnableHeadersVisualStyles = false;
            this.dgv_rutas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_rutas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_rutas.Location = new System.Drawing.Point(3, 3);
            this.dgv_rutas.Name = "dgv_rutas";
            this.dgv_rutas.ReadOnly = true;
            this.dgv_rutas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rutas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_rutas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_rutas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_rutas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_rutas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_rutas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rutas.Size = new System.Drawing.Size(1278, 626);
            this.dgv_rutas.TabIndex = 1;
            // 
            // btnquitarfiltro
            // 
            this.btnquitarfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnquitarfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitarfiltro.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark;
            this.btnquitarfiltro.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnquitarfiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnquitarfiltro.IconSize = 19;
            this.btnquitarfiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquitarfiltro.Location = new System.Drawing.Point(474, 37);
            this.btnquitarfiltro.Name = "btnquitarfiltro";
            this.btnquitarfiltro.Size = new System.Drawing.Size(28, 23);
            this.btnquitarfiltro.TabIndex = 298;
            this.btnquitarfiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquitarfiltro.UseVisualStyleBackColor = true;
            this.btnquitarfiltro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 297;
            this.label2.Text = "Por:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(63, 37);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(240, 23);
            this.txtbusqueda.TabIndex = 296;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 295;
            this.label8.Text = "Buscar:";
            // 
            // cbofiltro
            // 
            this.cbofiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbofiltro.FormattingEnabled = true;
            this.cbofiltro.Location = new System.Drawing.Point(342, 36);
            this.cbofiltro.Name = "cbofiltro";
            this.cbofiltro.Size = new System.Drawing.Size(129, 24);
            this.cbofiltro.TabIndex = 294;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 27);
            this.label1.TabIndex = 293;
            this.label1.Text = "Lista de Rutas";
            // 
            // menubotones
            // 
            this.menubotones.AutoSize = false;
            this.menubotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menubotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnexportarexcel});
            this.menubotones.Location = new System.Drawing.Point(0, 0);
            this.menubotones.Name = "menubotones";
            this.menubotones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menubotones.Size = new System.Drawing.Size(1283, 60);
            this.menubotones.TabIndex = 292;
            this.menubotones.Text = "menuStrip1";
            // 
            // btnexportarexcel
            // 
            this.btnexportarexcel.BackColor = System.Drawing.Color.Transparent;
            this.btnexportarexcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnexportarexcel.ForeColor = System.Drawing.Color.White;
            this.btnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnexportarexcel.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexportarexcel.IconSize = 36;
            this.btnexportarexcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnexportarexcel.Name = "btnexportarexcel";
            this.btnexportarexcel.Size = new System.Drawing.Size(48, 56);
            this.btnexportarexcel.Text = "Excel";
            this.btnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnquitarfiltro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbusqueda);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbofiltro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menubotones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 65);
            this.panel1.TabIndex = 5;
            // 
            // IdRuta
            // 
            dataGridViewCellStyle2.Format = "0000";
            this.IdRuta.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdRuta.HeaderText = "IdRuta";
            this.IdRuta.Name = "IdRuta";
            this.IdRuta.ReadOnly = true;
            this.IdRuta.Width = 90;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            this.Direccion.Width = 110;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 125;
            // 
            // VentanaTiempoDesde
            // 
            this.VentanaTiempoDesde.HeaderText = "Ventana_Tiempo_Desde";
            this.VentanaTiempoDesde.Name = "VentanaTiempoDesde";
            this.VentanaTiempoDesde.ReadOnly = true;
            this.VentanaTiempoDesde.Visible = false;
            this.VentanaTiempoDesde.Width = 130;
            // 
            // VentanaTiempoHasta
            // 
            this.VentanaTiempoHasta.HeaderText = "Ventana_Tiempo_Hasta";
            this.VentanaTiempoHasta.Name = "VentanaTiempoHasta";
            this.VentanaTiempoHasta.ReadOnly = true;
            this.VentanaTiempoHasta.Visible = false;
            this.VentanaTiempoHasta.Width = 110;
            // 
            // Cargas
            // 
            this.Cargas.HeaderText = "Cargas";
            this.Cargas.Name = "Cargas";
            this.Cargas.ReadOnly = true;
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.HeaderText = "IdVehiculo";
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.ReadOnly = true;
            this.IdVehiculo.Visible = false;
            // 
            // NombreVehiculo
            // 
            this.NombreVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreVehiculo.HeaderText = "Vehículo";
            this.NombreVehiculo.Name = "NombreVehiculo";
            this.NombreVehiculo.ReadOnly = true;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Visible = false;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.HeaderText = "Teléfono Cliente";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            this.TelefonoCliente.Visible = false;
            this.TelefonoCliente.Width = 140;
            // 
            // Telefono2Cliente
            // 
            this.Telefono2Cliente.HeaderText = "Teléfono 2 Cliente";
            this.Telefono2Cliente.Name = "Telefono2Cliente";
            this.Telefono2Cliente.ReadOnly = true;
            this.Telefono2Cliente.Visible = false;
            // 
            // EmailCliente
            // 
            this.EmailCliente.HeaderText = "E-mail Cliente";
            this.EmailCliente.Name = "EmailCliente";
            this.EmailCliente.ReadOnly = true;
            this.EmailCliente.Visible = false;
            // 
            // Comentarios
            // 
            this.Comentarios.HeaderText = "Comentarios";
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.ReadOnly = true;
            this.Comentarios.Visible = false;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
            // 
            // frm_BuscarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1285, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BuscarRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Rutas";
            this.Load += new System.EventHandler(this.frm_BuscarRutas_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutas)).EndInit();
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid dgv_rutas;
        private FontAwesome.Sharp.IconButton btnquitarfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbofiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnexportarexcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentanaTiempoDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentanaTiempoHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}