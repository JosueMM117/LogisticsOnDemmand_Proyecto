namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    partial class frm_Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vehiculos));
            this.tbctlvehiculos = new MetroFramework.Controls.MetroTabControl();
            this.tabpginformacion = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nuphoraiodisponibilidad = new System.Windows.Forms.NumericUpDown();
            this.nupcargaminima = new System.Windows.Forms.NumericUpDown();
            this.nupcargamaxima = new System.Windows.Forms.NumericUpDown();
            this.txtidconductor = new System.Windows.Forms.Label();
            this.btnbuscarconductor = new FontAwesome.Sharp.IconButton();
            this.txtnombreconductor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnhabilidad = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbohabilidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombrevehiculo = new System.Windows.Forms.TextBox();
            this.tabpgrutas = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menubotones = new System.Windows.Forms.MenuStrip();
            this.btnadicionar = new FontAwesome.Sharp.IconMenuItem();
            this.btnguardar = new FontAwesome.Sharp.IconMenuItem();
            this.btneditar = new FontAwesome.Sharp.IconMenuItem();
            this.btnborrar = new FontAwesome.Sharp.IconMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtidvehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbctlvehiculos.SuspendLayout();
            this.tabpginformacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuphoraiodisponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargaminima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargamaxima)).BeginInit();
            this.tabpgrutas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menubotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctlvehiculos
            // 
            this.tbctlvehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlvehiculos.Controls.Add(this.tabpginformacion);
            this.tbctlvehiculos.Controls.Add(this.tabpgrutas);
            this.tbctlvehiculos.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbctlvehiculos.Location = new System.Drawing.Point(3, 110);
            this.tbctlvehiculos.Name = "tbctlvehiculos";
            this.tbctlvehiculos.SelectedIndex = 0;
            this.tbctlvehiculos.Size = new System.Drawing.Size(924, 353);
            this.tbctlvehiculos.TabIndex = 3;
            this.tbctlvehiculos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbctlvehiculos.UseSelectable = true;
            // 
            // tabpginformacion
            // 
            this.tabpginformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabpginformacion.Controls.Add(this.panel2);
            this.tabpginformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabpginformacion.ForeColor = System.Drawing.Color.White;
            this.tabpginformacion.HorizontalScrollbarBarColor = true;
            this.tabpginformacion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpginformacion.HorizontalScrollbarSize = 10;
            this.tabpginformacion.Location = new System.Drawing.Point(4, 38);
            this.tabpginformacion.Name = "tabpginformacion";
            this.tabpginformacion.Size = new System.Drawing.Size(916, 311);
            this.tabpginformacion.TabIndex = 0;
            this.tabpginformacion.Text = "Datos";
            this.tabpginformacion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpginformacion.VerticalScrollbarBarColor = true;
            this.tabpginformacion.VerticalScrollbarHighlightOnWheel = false;
            this.tabpginformacion.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.nuphoraiodisponibilidad);
            this.panel2.Controls.Add(this.nupcargaminima);
            this.panel2.Controls.Add(this.nupcargamaxima);
            this.panel2.Controls.Add(this.txtidconductor);
            this.panel2.Controls.Add(this.btnbuscarconductor);
            this.panel2.Controls.Add(this.txtnombreconductor);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnhabilidad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbohabilidad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboestado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtidentificacion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtmarca);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtnombrevehiculo);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 312);
            this.panel2.TabIndex = 2;
            // 
            // nuphoraiodisponibilidad
            // 
            this.nuphoraiodisponibilidad.Location = new System.Drawing.Point(376, 133);
            this.nuphoraiodisponibilidad.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nuphoraiodisponibilidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuphoraiodisponibilidad.Name = "nuphoraiodisponibilidad";
            this.nuphoraiodisponibilidad.Size = new System.Drawing.Size(120, 23);
            this.nuphoraiodisponibilidad.TabIndex = 314;
            this.nuphoraiodisponibilidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupcargaminima
            // 
            this.nupcargaminima.Location = new System.Drawing.Point(376, 34);
            this.nupcargaminima.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupcargaminima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupcargaminima.Name = "nupcargaminima";
            this.nupcargaminima.Size = new System.Drawing.Size(120, 23);
            this.nupcargaminima.TabIndex = 313;
            this.nupcargaminima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupcargamaxima
            // 
            this.nupcargamaxima.Location = new System.Drawing.Point(376, 82);
            this.nupcargamaxima.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupcargamaxima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupcargamaxima.Name = "nupcargamaxima";
            this.nupcargamaxima.Size = new System.Drawing.Size(120, 23);
            this.nupcargamaxima.TabIndex = 312;
            this.nupcargamaxima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtidconductor
            // 
            this.txtidconductor.AutoSize = true;
            this.txtidconductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidconductor.ForeColor = System.Drawing.Color.White;
            this.txtidconductor.Location = new System.Drawing.Point(784, 11);
            this.txtidconductor.Name = "txtidconductor";
            this.txtidconductor.Size = new System.Drawing.Size(16, 17);
            this.txtidconductor.TabIndex = 311;
            this.txtidconductor.Text = "0";
            this.txtidconductor.Visible = false;
            // 
            // btnbuscarconductor
            // 
            this.btnbuscarconductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnbuscarconductor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnbuscarconductor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarconductor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnbuscarconductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnbuscarconductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarconductor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarconductor.ForeColor = System.Drawing.Color.White;
            this.btnbuscarconductor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarconductor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarconductor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarconductor.IconSize = 17;
            this.btnbuscarconductor.Location = new System.Drawing.Point(872, 31);
            this.btnbuscarconductor.Name = "btnbuscarconductor";
            this.btnbuscarconductor.Size = new System.Drawing.Size(24, 25);
            this.btnbuscarconductor.TabIndex = 310;
            this.btnbuscarconductor.UseVisualStyleBackColor = false;
            this.btnbuscarconductor.Click += new System.EventHandler(this.btnbuscarconductor_Click);
            // 
            // txtnombreconductor
            // 
            this.txtnombreconductor.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreconductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreconductor.ForeColor = System.Drawing.Color.Black;
            this.txtnombreconductor.Location = new System.Drawing.Point(549, 32);
            this.txtnombreconductor.Name = "txtnombreconductor";
            this.txtnombreconductor.Size = new System.Drawing.Size(320, 23);
            this.txtnombreconductor.TabIndex = 309;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(547, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 308;
            this.label10.Text = "Conductor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(373, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 307;
            this.label9.Text = "Horas Disp. (al día):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(375, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 306;
            this.label8.Text = "Carga Mínima:";
            // 
            // btnhabilidad
            // 
            this.btnhabilidad.FlatAppearance.BorderSize = 0;
            this.btnhabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhabilidad.ForeColor = System.Drawing.Color.White;
            this.btnhabilidad.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnhabilidad.IconColor = System.Drawing.Color.LimeGreen;
            this.btnhabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhabilidad.IconSize = 24;
            this.btnhabilidad.Location = new System.Drawing.Point(330, 186);
            this.btnhabilidad.Name = "btnhabilidad";
            this.btnhabilidad.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnhabilidad.Size = new System.Drawing.Size(30, 24);
            this.btnhabilidad.TabIndex = 305;
            this.btnhabilidad.UseVisualStyleBackColor = true;
            this.btnhabilidad.Click += new System.EventHandler(this.btnhabilidad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 304;
            this.label6.Text = "Habilidad:";
            // 
            // cbohabilidad
            // 
            this.cbohabilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbohabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbohabilidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbohabilidad.Location = new System.Drawing.Point(9, 186);
            this.cbohabilidad.Name = "cbohabilidad";
            this.cbohabilidad.Size = new System.Drawing.Size(315, 24);
            this.cbohabilidad.TabIndex = 303;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 302;
            this.label5.Text = "Carga Máxima:";
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboestado.Location = new System.Drawing.Point(9, 238);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(127, 24);
            this.cboestado.TabIndex = 301;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 300;
            this.label7.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 299;
            this.label4.Text = "Identificacíon o Matrícula:";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacion.Location = new System.Drawing.Point(9, 133);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(351, 23);
            this.txtidentificacion.TabIndex = 298;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 297;
            this.label2.Text = "Marca:";
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(9, 83);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(351, 23);
            this.txtmarca.TabIndex = 296;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 295;
            this.label3.Text = "Nombre:";
            // 
            // txtnombrevehiculo
            // 
            this.txtnombrevehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrevehiculo.Location = new System.Drawing.Point(9, 34);
            this.txtnombrevehiculo.Name = "txtnombrevehiculo";
            this.txtnombrevehiculo.Size = new System.Drawing.Size(351, 23);
            this.txtnombrevehiculo.TabIndex = 294;
            // 
            // tabpgrutas
            // 
            this.tabpgrutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabpgrutas.Controls.Add(this.panel4);
            this.tabpgrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabpgrutas.ForeColor = System.Drawing.Color.White;
            this.tabpgrutas.HorizontalScrollbarBarColor = true;
            this.tabpgrutas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpgrutas.HorizontalScrollbarSize = 10;
            this.tabpgrutas.Location = new System.Drawing.Point(4, 38);
            this.tabpgrutas.Name = "tabpgrutas";
            this.tabpgrutas.Size = new System.Drawing.Size(916, 311);
            this.tabpgrutas.TabIndex = 1;
            this.tabpgrutas.Text = "Rutas";
            this.tabpgrutas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpgrutas.VerticalScrollbarBarColor = true;
            this.tabpgrutas.VerticalScrollbarHighlightOnWheel = false;
            this.tabpgrutas.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(918, 312);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbctlvehiculos);
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 468);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.txtidvehiculo);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 101);
            this.panel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.menubotones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(922, 64);
            this.panel5.TabIndex = 290;
            // 
            // menubotones
            // 
            this.menubotones.AutoSize = false;
            this.menubotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menubotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnadicionar,
            this.btnguardar,
            this.btneditar,
            this.btnborrar});
            this.menubotones.Location = new System.Drawing.Point(0, 0);
            this.menubotones.Name = "menubotones";
            this.menubotones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menubotones.Size = new System.Drawing.Size(920, 63);
            this.menubotones.TabIndex = 291;
            this.menubotones.Text = "menuStrip1";
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnadicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnadicionar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnadicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnadicionar.IconSize = 40;
            this.btnadicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(71, 59);
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 40;
            this.btnguardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(64, 59);
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btneditar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 40;
            this.btneditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(52, 59);
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnborrar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 40;
            this.btnborrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(55, 59);
            this.btnborrar.Text = "Borrar";
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 289;
            this.label11.Text = "IdVehiculo:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 17;
            this.btnbuscar.Location = new System.Drawing.Point(170, 70);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 25);
            this.btnbuscar.TabIndex = 289;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtidvehiculo
            // 
            this.txtidvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidvehiculo.Location = new System.Drawing.Point(86, 71);
            this.txtidvehiculo.Name = "txtidvehiculo";
            this.txtidvehiculo.Size = new System.Drawing.Size(82, 23);
            this.txtidvehiculo.TabIndex = 289;
            this.txtidvehiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidvehiculo_KeyDown);
            this.txtidvehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidvehiculo_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mantenimiento de Vehículos\r\n";
            // 
            // frm_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(938, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Vehiculos";
            this.Text = "Mantenimiento de Vehículos";
            this.Load += new System.EventHandler(this.frm_Vehiculos_Load);
            this.tbctlvehiculos.ResumeLayout(false);
            this.tabpginformacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuphoraiodisponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargaminima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargamaxima)).EndInit();
            this.tabpgrutas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tbctlvehiculos;
        private MetroFramework.Controls.MetroTabPage tabpgrutas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage tabpginformacion;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtidvehiculo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnadicionar;
        private FontAwesome.Sharp.IconMenuItem btnguardar;
        private FontAwesome.Sharp.IconMenuItem btneditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nuphoraiodisponibilidad;
        private System.Windows.Forms.NumericUpDown nupcargaminima;
        private System.Windows.Forms.NumericUpDown nupcargamaxima;
        private System.Windows.Forms.Label txtidconductor;
        private FontAwesome.Sharp.IconButton btnbuscarconductor;
        private System.Windows.Forms.Label txtnombreconductor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnhabilidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbohabilidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombrevehiculo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconMenuItem btnborrar;
    }
}