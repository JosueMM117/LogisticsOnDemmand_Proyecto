namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    partial class frm_Rutas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rutas));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menubotones = new System.Windows.Forms.MenuStrip();
            this.btnadicionar = new FontAwesome.Sharp.IconMenuItem();
            this.btnguardar = new FontAwesome.Sharp.IconMenuItem();
            this.btnprocesar = new FontAwesome.Sharp.IconMenuItem();
            this.btneditar = new FontAwesome.Sharp.IconMenuItem();
            this.btnborrar = new FontAwesome.Sharp.IconMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtidruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbctlrutas = new MetroFramework.Controls.MetroTabControl();
            this.tabpgdatosruta = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttiemporuta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcomentarios = new System.Windows.Forms.TextBox();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.dtpfechaentrega = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nupcargas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboprioridad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.tabpbdatosenvio = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbdetalledestinos = new System.Windows.Forms.GroupBox();
            this.dgvdetalleruta = new MetroFramework.Controls.MetroGrid();
            this.IdDetalleRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatitudDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongitudDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbclientes = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtemailcliente = new System.Windows.Forms.TextBox();
            this.label996 = new System.Windows.Forms.Label();
            this.txtdireccioncliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttelefono2cliente = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txttelefonocliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.gbdatosvehiculo = new System.Windows.Forms.GroupBox();
            this.lblidvehiculo = new System.Windows.Forms.Label();
            this.txtidvehiculo = new System.Windows.Forms.TextBox();
            this.btnbuscarvehiculo = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnagregardestino = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txthabilidadvehiculo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnombrevehiculo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombreconductor = new System.Windows.Forms.Label();
            this.tabpgmapa = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbmapa = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btncargarubicacionactual = new FontAwesome.Sharp.IconButton();
            this.gMaprutas = new GMap.NET.WindowsForms.GMapControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btncargarruta = new FontAwesome.Sharp.IconButton();
            this.txtlongitud = new System.Windows.Forms.Label();
            this.txtlatitud = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menubotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbctlrutas.SuspendLayout();
            this.tabpgdatosruta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargas)).BeginInit();
            this.tabpbdatosenvio.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbdetalledestinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleruta)).BeginInit();
            this.gbclientes.SuspendLayout();
            this.gbdatosvehiculo.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabpgmapa.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbmapa.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.txtidruta);
            this.panel3.Location = new System.Drawing.Point(5, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 101);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.menubotones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1202, 64);
            this.panel5.TabIndex = 290;
            // 
            // menubotones
            // 
            this.menubotones.AutoSize = false;
            this.menubotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menubotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnadicionar,
            this.btnguardar,
            this.btnprocesar,
            this.btneditar,
            this.btnborrar});
            this.menubotones.Location = new System.Drawing.Point(0, 0);
            this.menubotones.Name = "menubotones";
            this.menubotones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menubotones.Size = new System.Drawing.Size(1200, 63);
            this.menubotones.TabIndex = 291;
            this.menubotones.Text = "menuStrip1";
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnadicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnadicionar.ForeColor = System.Drawing.SystemColors.Control;
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
            this.btnguardar.ForeColor = System.Drawing.SystemColors.Control;
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
            // btnprocesar
            // 
            this.btnprocesar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnprocesar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnprocesar.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnprocesar.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnprocesar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnprocesar.IconSize = 40;
            this.btnprocesar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(67, 59);
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.ForeColor = System.Drawing.SystemColors.Control;
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
            this.btnborrar.ForeColor = System.Drawing.SystemColors.Control;
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
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 289;
            this.label11.Text = "IdRuta:";
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
            this.btnbuscar.Location = new System.Drawing.Point(144, 70);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 25);
            this.btnbuscar.TabIndex = 289;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtidruta
            // 
            this.txtidruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidruta.Location = new System.Drawing.Point(60, 71);
            this.txtidruta.Name = "txtidruta";
            this.txtidruta.Size = new System.Drawing.Size(82, 23);
            this.txtidruta.TabIndex = 289;
            this.txtidruta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidruta_KeyDown);
            this.txtidruta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidruta_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenimiento de Rutas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.tbctlrutas);
            this.panel1.Location = new System.Drawing.Point(5, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 588);
            this.panel1.TabIndex = 7;
            // 
            // tbctlrutas
            // 
            this.tbctlrutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlrutas.Controls.Add(this.tabpgdatosruta);
            this.tbctlrutas.Controls.Add(this.tabpbdatosenvio);
            this.tbctlrutas.Controls.Add(this.tabpgmapa);
            this.tbctlrutas.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbctlrutas.Location = new System.Drawing.Point(3, 3);
            this.tbctlrutas.Multiline = true;
            this.tbctlrutas.Name = "tbctlrutas";
            this.tbctlrutas.SelectedIndex = 0;
            this.tbctlrutas.Size = new System.Drawing.Size(1198, 582);
            this.tbctlrutas.TabIndex = 3;
            this.tbctlrutas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbctlrutas.UseSelectable = true;
            this.tbctlrutas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbctlvehiculos_Selected);
            // 
            // tabpgdatosruta
            // 
            this.tabpgdatosruta.BackColor = System.Drawing.Color.Black;
            this.tabpgdatosruta.Controls.Add(this.panel2);
            this.tabpgdatosruta.HorizontalScrollbarBarColor = true;
            this.tabpgdatosruta.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpgdatosruta.HorizontalScrollbarSize = 10;
            this.tabpgdatosruta.Location = new System.Drawing.Point(4, 38);
            this.tabpgdatosruta.Name = "tabpgdatosruta";
            this.tabpgdatosruta.Size = new System.Drawing.Size(1190, 540);
            this.tabpgdatosruta.TabIndex = 5;
            this.tabpgdatosruta.Text = "Datos de Ruta";
            this.tabpgdatosruta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpgdatosruta.VerticalScrollbarBarColor = true;
            this.tabpgdatosruta.VerticalScrollbarHighlightOnWheel = false;
            this.tabpgdatosruta.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.txttiemporuta);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtcomentarios);
            this.panel2.Controls.Add(this.cboestado);
            this.panel2.Controls.Add(this.dtpfechaentrega);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nupcargas);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cboprioridad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtconcepto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txttitulo);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 540);
            this.panel2.TabIndex = 2;
            // 
            // txttiemporuta
            // 
            this.txttiemporuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiemporuta.Location = new System.Drawing.Point(561, 138);
            this.txttiemporuta.Name = "txttiemporuta";
            this.txttiemporuta.Size = new System.Drawing.Size(66, 23);
            this.txttiemporuta.TabIndex = 383;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(380, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 17);
            this.label17.TabIndex = 381;
            this.label17.Text = "Tiempo Estimado de Ruta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 379;
            this.label9.Text = "Notas Adicionales:";
            // 
            // txtcomentarios
            // 
            this.txtcomentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomentarios.Location = new System.Drawing.Point(16, 137);
            this.txtcomentarios.Multiline = true;
            this.txtcomentarios.Name = "txtcomentarios";
            this.txtcomentarios.Size = new System.Drawing.Size(350, 108);
            this.txtcomentarios.TabIndex = 378;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboestado.Location = new System.Drawing.Point(638, 81);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(189, 24);
            this.cboestado.TabIndex = 376;
            // 
            // dtpfechaentrega
            // 
            this.dtpfechaentrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechaentrega.Location = new System.Drawing.Point(382, 31);
            this.dtpfechaentrega.Name = "dtpfechaentrega";
            this.dtpfechaentrega.Size = new System.Drawing.Size(115, 23);
            this.dtpfechaentrega.TabIndex = 375;
            this.dtpfechaentrega.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 374;
            this.label8.Text = "Fecha Entrega:";
            // 
            // nupcargas
            // 
            this.nupcargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupcargas.Location = new System.Drawing.Point(507, 31);
            this.nupcargas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupcargas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupcargas.Name = "nupcargas";
            this.nupcargas.Size = new System.Drawing.Size(120, 23);
            this.nupcargas.TabIndex = 372;
            this.nupcargas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 365;
            this.label6.Text = "Prioridad:";
            // 
            // cboprioridad
            // 
            this.cboprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboprioridad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboprioridad.Location = new System.Drawing.Point(382, 81);
            this.cboprioridad.Name = "cboprioridad";
            this.cboprioridad.Size = new System.Drawing.Size(245, 24);
            this.cboprioridad.TabIndex = 364;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 363;
            this.label5.Text = "Cargas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(635, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 362;
            this.label7.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 359;
            this.label2.Text = "Concepto:";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconcepto.Location = new System.Drawing.Point(15, 82);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(351, 23);
            this.txtconcepto.TabIndex = 358;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 357;
            this.label3.Text = "Título:";
            // 
            // txttitulo
            // 
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(15, 33);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(351, 23);
            this.txttitulo.TabIndex = 356;
            // 
            // tabpbdatosenvio
            // 
            this.tabpbdatosenvio.Controls.Add(this.panel4);
            this.tabpbdatosenvio.HorizontalScrollbarBarColor = true;
            this.tabpbdatosenvio.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpbdatosenvio.HorizontalScrollbarSize = 10;
            this.tabpbdatosenvio.Location = new System.Drawing.Point(4, 38);
            this.tabpbdatosenvio.Name = "tabpbdatosenvio";
            this.tabpbdatosenvio.Size = new System.Drawing.Size(1190, 540);
            this.tabpbdatosenvio.TabIndex = 6;
            this.tabpbdatosenvio.Text = "Datos de Envío";
            this.tabpbdatosenvio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpbdatosenvio.VerticalScrollbarBarColor = true;
            this.tabpbdatosenvio.VerticalScrollbarHighlightOnWheel = false;
            this.tabpbdatosenvio.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.gbdetalledestinos);
            this.panel4.Controls.Add(this.gbclientes);
            this.panel4.Controls.Add(this.gbdatosvehiculo);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 532);
            this.panel4.TabIndex = 3;
            // 
            // gbdetalledestinos
            // 
            this.gbdetalledestinos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdetalledestinos.Controls.Add(this.dgvdetalleruta);
            this.gbdetalledestinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdetalledestinos.ForeColor = System.Drawing.Color.White;
            this.gbdetalledestinos.Location = new System.Drawing.Point(12, 239);
            this.gbdetalledestinos.Name = "gbdetalledestinos";
            this.gbdetalledestinos.Size = new System.Drawing.Size(1171, 290);
            this.gbdetalledestinos.TabIndex = 389;
            this.gbdetalledestinos.TabStop = false;
            this.gbdetalledestinos.Text = "Detalle Destinos";
            // 
            // dgvdetalleruta
            // 
            this.dgvdetalleruta.AllowUserToAddRows = false;
            this.dgvdetalleruta.AllowUserToDeleteRows = false;
            this.dgvdetalleruta.AllowUserToResizeRows = false;
            this.dgvdetalleruta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalleruta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdetalleruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdetalleruta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvdetalleruta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalleruta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalleruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleRuta,
            this.IdRuta,
            this.IdVehiculo,
            this.NombreVehiculo,
            this.Conductor,
            this.DireccionEnvio,
            this.LatitudDestino,
            this.LongitudDestino,
            this.NombreCliente,
            this.Telefono1,
            this.Telefono2,
            this.EmailCliente,
            this.FechaRegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalleruta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetalleruta.EnableHeadersVisualStyles = false;
            this.dgvdetalleruta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvdetalleruta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvdetalleruta.Location = new System.Drawing.Point(6, 22);
            this.dgvdetalleruta.Name = "dgvdetalleruta";
            this.dgvdetalleruta.ReadOnly = true;
            this.dgvdetalleruta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalleruta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetalleruta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvdetalleruta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvdetalleruta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvdetalleruta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvdetalleruta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvdetalleruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalleruta.Size = new System.Drawing.Size(1159, 262);
            this.dgvdetalleruta.TabIndex = 358;
            this.dgvdetalleruta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalleruta_CellDoubleClick);
            // 
            // IdDetalleRuta
            // 
            this.IdDetalleRuta.HeaderText = "IdDetalleRuta";
            this.IdDetalleRuta.Name = "IdDetalleRuta";
            this.IdDetalleRuta.ReadOnly = true;
            this.IdDetalleRuta.Visible = false;
            // 
            // IdRuta
            // 
            this.IdRuta.HeaderText = "IdRuta";
            this.IdRuta.Name = "IdRuta";
            this.IdRuta.ReadOnly = true;
            this.IdRuta.Visible = false;
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
            this.NombreVehiculo.HeaderText = "Nombre Vehículo";
            this.NombreVehiculo.Name = "NombreVehiculo";
            this.NombreVehiculo.ReadOnly = true;
            // 
            // Conductor
            // 
            this.Conductor.HeaderText = "Conductor";
            this.Conductor.Name = "Conductor";
            this.Conductor.ReadOnly = true;
            this.Conductor.Width = 130;
            // 
            // DireccionEnvio
            // 
            this.DireccionEnvio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DireccionEnvio.HeaderText = "Direccion Envío";
            this.DireccionEnvio.Name = "DireccionEnvio";
            this.DireccionEnvio.ReadOnly = true;
            // 
            // LatitudDestino
            // 
            this.LatitudDestino.HeaderText = "Latitud Destino";
            this.LatitudDestino.Name = "LatitudDestino";
            this.LatitudDestino.ReadOnly = true;
            this.LatitudDestino.Visible = false;
            // 
            // LongitudDestino
            // 
            this.LongitudDestino.HeaderText = "Longitud Destino";
            this.LongitudDestino.Name = "LongitudDestino";
            this.LongitudDestino.ReadOnly = true;
            this.LongitudDestino.Visible = false;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // Telefono1
            // 
            this.Telefono1.HeaderText = "Teléfono 1";
            this.Telefono1.Name = "Telefono1";
            this.Telefono1.ReadOnly = true;
            // 
            // Telefono2
            // 
            this.Telefono2.HeaderText = "Teléfono 2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.ReadOnly = true;
            // 
            // EmailCliente
            // 
            this.EmailCliente.HeaderText = "Email";
            this.EmailCliente.Name = "EmailCliente";
            this.EmailCliente.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Visible = false;
            // 
            // gbclientes
            // 
            this.gbclientes.Controls.Add(this.label20);
            this.gbclientes.Controls.Add(this.txtemailcliente);
            this.gbclientes.Controls.Add(this.label996);
            this.gbclientes.Controls.Add(this.txtdireccioncliente);
            this.gbclientes.Controls.Add(this.label12);
            this.gbclientes.Controls.Add(this.txttelefono2cliente);
            this.gbclientes.Controls.Add(this.label21);
            this.gbclientes.Controls.Add(this.txttelefonocliente);
            this.gbclientes.Controls.Add(this.label22);
            this.gbclientes.Controls.Add(this.txtnombrecliente);
            this.gbclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbclientes.ForeColor = System.Drawing.Color.White;
            this.gbclientes.Location = new System.Drawing.Point(12, 17);
            this.gbclientes.Name = "gbclientes";
            this.gbclientes.Size = new System.Drawing.Size(558, 216);
            this.gbclientes.TabIndex = 388;
            this.gbclientes.TabStop = false;
            this.gbclientes.Text = "Información Cliente";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 394;
            this.label20.Text = "E-Mail:";
            // 
            // txtemailcliente
            // 
            this.txtemailcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcliente.Location = new System.Drawing.Point(8, 98);
            this.txtemailcliente.Name = "txtemailcliente";
            this.txtemailcliente.Size = new System.Drawing.Size(351, 23);
            this.txtemailcliente.TabIndex = 393;
            // 
            // label996
            // 
            this.label996.AutoSize = true;
            this.label996.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label996.ForeColor = System.Drawing.Color.White;
            this.label996.Location = new System.Drawing.Point(6, 126);
            this.label996.Name = "label996";
            this.label996.Size = new System.Drawing.Size(109, 17);
            this.label996.TabIndex = 392;
            this.label996.Text = "Dirección envio:";
            // 
            // txtdireccioncliente
            // 
            this.txtdireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccioncliente.Location = new System.Drawing.Point(8, 147);
            this.txtdireccioncliente.Name = "txtdireccioncliente";
            this.txtdireccioncliente.Size = new System.Drawing.Size(533, 23);
            this.txtdireccioncliente.TabIndex = 391;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(365, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 384;
            this.label12.Text = "Teléfono 2:";
            // 
            // txttelefono2cliente
            // 
            this.txttelefono2cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono2cliente.Location = new System.Drawing.Point(367, 97);
            this.txttelefono2cliente.Name = "txttelefono2cliente";
            this.txttelefono2cliente.Size = new System.Drawing.Size(174, 23);
            this.txttelefono2cliente.TabIndex = 383;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(365, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 380;
            this.label21.Text = "Teléfono:";
            // 
            // txttelefonocliente
            // 
            this.txttelefonocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonocliente.Location = new System.Drawing.Point(367, 48);
            this.txttelefonocliente.Name = "txttelefonocliente";
            this.txttelefonocliente.Size = new System.Drawing.Size(174, 23);
            this.txttelefonocliente.TabIndex = 379;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 17);
            this.label22.TabIndex = 388;
            this.label22.Text = "Nombre Completo:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(8, 48);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(351, 23);
            this.txtnombrecliente.TabIndex = 387;
            // 
            // gbdatosvehiculo
            // 
            this.gbdatosvehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbdatosvehiculo.Controls.Add(this.lblidvehiculo);
            this.gbdatosvehiculo.Controls.Add(this.txtidvehiculo);
            this.gbdatosvehiculo.Controls.Add(this.btnbuscarvehiculo);
            this.gbdatosvehiculo.Controls.Add(this.panel8);
            this.gbdatosvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatosvehiculo.ForeColor = System.Drawing.Color.White;
            this.gbdatosvehiculo.Location = new System.Drawing.Point(576, 17);
            this.gbdatosvehiculo.Name = "gbdatosvehiculo";
            this.gbdatosvehiculo.Size = new System.Drawing.Size(607, 216);
            this.gbdatosvehiculo.TabIndex = 387;
            this.gbdatosvehiculo.TabStop = false;
            this.gbdatosvehiculo.Text = "Información de Vehículo";
            // 
            // lblidvehiculo
            // 
            this.lblidvehiculo.AutoSize = true;
            this.lblidvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidvehiculo.ForeColor = System.Drawing.Color.White;
            this.lblidvehiculo.Location = new System.Drawing.Point(6, 32);
            this.lblidvehiculo.Name = "lblidvehiculo";
            this.lblidvehiculo.Size = new System.Drawing.Size(77, 17);
            this.lblidvehiculo.TabIndex = 380;
            this.lblidvehiculo.Text = "IdVehiculo:";
            // 
            // txtidvehiculo
            // 
            this.txtidvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidvehiculo.Location = new System.Drawing.Point(89, 29);
            this.txtidvehiculo.Name = "txtidvehiculo";
            this.txtidvehiculo.Size = new System.Drawing.Size(82, 23);
            this.txtidvehiculo.TabIndex = 379;
            this.txtidvehiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidvehiculo_KeyDown);
            this.txtidvehiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidvehiculo_KeyPress);
            this.txtidvehiculo.MouseLeave += new System.EventHandler(this.txtidvehiculo_MouseLeave);
            // 
            // btnbuscarvehiculo
            // 
            this.btnbuscarvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnbuscarvehiculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnbuscarvehiculo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarvehiculo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnbuscarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnbuscarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarvehiculo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarvehiculo.ForeColor = System.Drawing.Color.White;
            this.btnbuscarvehiculo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarvehiculo.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnbuscarvehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarvehiculo.IconSize = 17;
            this.btnbuscarvehiculo.Location = new System.Drawing.Point(173, 28);
            this.btnbuscarvehiculo.Name = "btnbuscarvehiculo";
            this.btnbuscarvehiculo.Size = new System.Drawing.Size(24, 25);
            this.btnbuscarvehiculo.TabIndex = 378;
            this.btnbuscarvehiculo.UseVisualStyleBackColor = false;
            this.btnbuscarvehiculo.Click += new System.EventHandler(this.btnbuscarvehiculo_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnagregardestino);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.txthabilidadvehiculo);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.txtnombrevehiculo);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.txtnombreconductor);
            this.panel8.Location = new System.Drawing.Point(6, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(598, 153);
            this.panel8.TabIndex = 377;
            // 
            // btnagregardestino
            // 
            this.btnagregardestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnagregardestino.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnagregardestino.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnagregardestino.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnagregardestino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnagregardestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregardestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnagregardestino.ForeColor = System.Drawing.Color.White;
            this.btnagregardestino.IconChar = FontAwesome.Sharp.IconChar.MapPin;
            this.btnagregardestino.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnagregardestino.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregardestino.IconSize = 19;
            this.btnagregardestino.Location = new System.Drawing.Point(462, 124);
            this.btnagregardestino.Name = "btnagregardestino";
            this.btnagregardestino.Size = new System.Drawing.Size(129, 24);
            this.btnagregardestino.TabIndex = 383;
            this.btnagregardestino.Text = "Agregar Destino";
            this.btnagregardestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregardestino.UseVisualStyleBackColor = false;
            this.btnagregardestino.Click += new System.EventHandler(this.btnagregardestino_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(275, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 380;
            this.label15.Text = "Habilidad:";
            this.label15.Visible = false;
            // 
            // txthabilidadvehiculo
            // 
            this.txthabilidadvehiculo.BackColor = System.Drawing.SystemColors.Window;
            this.txthabilidadvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthabilidadvehiculo.ForeColor = System.Drawing.Color.Black;
            this.txthabilidadvehiculo.Location = new System.Drawing.Point(274, 31);
            this.txthabilidadvehiculo.Name = "txthabilidadvehiculo";
            this.txthabilidadvehiculo.Size = new System.Drawing.Size(201, 23);
            this.txthabilidadvehiculo.TabIndex = 381;
            this.txthabilidadvehiculo.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 17);
            this.label14.TabIndex = 378;
            this.label14.Text = "Nombre Vehículo:";
            // 
            // txtnombrevehiculo
            // 
            this.txtnombrevehiculo.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombrevehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrevehiculo.ForeColor = System.Drawing.Color.Black;
            this.txtnombrevehiculo.Location = new System.Drawing.Point(7, 31);
            this.txtnombrevehiculo.Name = "txtnombrevehiculo";
            this.txtnombrevehiculo.Size = new System.Drawing.Size(253, 23);
            this.txtnombrevehiculo.TabIndex = 379;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 376;
            this.label10.Text = "Conductor:";
            // 
            // txtnombreconductor
            // 
            this.txtnombreconductor.BackColor = System.Drawing.SystemColors.Window;
            this.txtnombreconductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreconductor.ForeColor = System.Drawing.Color.Black;
            this.txtnombreconductor.Location = new System.Drawing.Point(7, 86);
            this.txtnombreconductor.Name = "txtnombreconductor";
            this.txtnombreconductor.Size = new System.Drawing.Size(254, 23);
            this.txtnombreconductor.TabIndex = 377;
            // 
            // tabpgmapa
            // 
            this.tabpgmapa.Controls.Add(this.panel6);
            this.tabpgmapa.HorizontalScrollbarBarColor = true;
            this.tabpgmapa.HorizontalScrollbarHighlightOnWheel = false;
            this.tabpgmapa.HorizontalScrollbarSize = 10;
            this.tabpgmapa.Location = new System.Drawing.Point(4, 38);
            this.tabpgmapa.Name = "tabpgmapa";
            this.tabpgmapa.Size = new System.Drawing.Size(1190, 540);
            this.tabpgmapa.TabIndex = 7;
            this.tabpgmapa.Text = "Direcciones/Mapa";
            this.tabpgmapa.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabpgmapa.VerticalScrollbarBarColor = true;
            this.tabpgmapa.VerticalScrollbarHighlightOnWheel = false;
            this.tabpgmapa.VerticalScrollbarSize = 10;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel6.Controls.Add(this.gbmapa);
            this.panel6.Location = new System.Drawing.Point(-4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1190, 535);
            this.panel6.TabIndex = 3;
            // 
            // gbmapa
            // 
            this.gbmapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbmapa.Controls.Add(this.panel9);
            this.gbmapa.Controls.Add(this.panel7);
            this.gbmapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmapa.ForeColor = System.Drawing.Color.White;
            this.gbmapa.Location = new System.Drawing.Point(4, 3);
            this.gbmapa.Name = "gbmapa";
            this.gbmapa.Size = new System.Drawing.Size(1187, 535);
            this.gbmapa.TabIndex = 360;
            this.gbmapa.TabStop = false;
            this.gbmapa.Text = "Mapa";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btncargarubicacionactual);
            this.panel9.Controls.Add(this.gMaprutas);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1181, 482);
            this.panel9.TabIndex = 1;
            // 
            // btncargarubicacionactual
            // 
            this.btncargarubicacionactual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargarubicacionactual.BackColor = System.Drawing.Color.White;
            this.btncargarubicacionactual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncargarubicacionactual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncargarubicacionactual.FlatAppearance.BorderSize = 0;
            this.btncargarubicacionactual.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btncargarubicacionactual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncargarubicacionactual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncargarubicacionactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btncargarubicacionactual.ForeColor = System.Drawing.Color.White;
            this.btncargarubicacionactual.IconChar = FontAwesome.Sharp.IconChar.LocationCrosshairs;
            this.btncargarubicacionactual.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncargarubicacionactual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncargarubicacionactual.IconSize = 30;
            this.btncargarubicacionactual.Location = new System.Drawing.Point(1130, 438);
            this.btncargarubicacionactual.Name = "btncargarubicacionactual";
            this.btncargarubicacionactual.Size = new System.Drawing.Size(31, 31);
            this.btncargarubicacionactual.TabIndex = 292;
            this.btncargarubicacionactual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargarubicacionactual.UseVisualStyleBackColor = false;
            this.btncargarubicacionactual.Click += new System.EventHandler(this.btncargarubicacionactual_Click);
            // 
            // gMaprutas
            // 
            this.gMaprutas.Bearing = 0F;
            this.gMaprutas.CanDragMap = true;
            this.gMaprutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMaprutas.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMaprutas.GrayScaleMode = false;
            this.gMaprutas.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMaprutas.LevelsKeepInMemory = 5;
            this.gMaprutas.Location = new System.Drawing.Point(0, 0);
            this.gMaprutas.MarkersEnabled = true;
            this.gMaprutas.MaxZoom = 24;
            this.gMaprutas.MinZoom = 0;
            this.gMaprutas.MouseWheelZoomEnabled = true;
            this.gMaprutas.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMaprutas.Name = "gMaprutas";
            this.gMaprutas.NegativeMode = false;
            this.gMaprutas.PolygonsEnabled = true;
            this.gMaprutas.RetryLoadTile = 0;
            this.gMaprutas.RoutesEnabled = true;
            this.gMaprutas.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMaprutas.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMaprutas.ShowTileGridLines = false;
            this.gMaprutas.Size = new System.Drawing.Size(1181, 482);
            this.gMaprutas.TabIndex = 0;
            this.gMaprutas.Zoom = 14D;
            this.gMaprutas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMaprutas_MouseDoubleClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btncargarruta);
            this.panel7.Controls.Add(this.txtlongitud);
            this.panel7.Controls.Add(this.txtlatitud);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1181, 33);
            this.panel7.TabIndex = 0;
            // 
            // btncargarruta
            // 
            this.btncargarruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btncargarruta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncargarruta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncargarruta.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btncargarruta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btncargarruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btncargarruta.ForeColor = System.Drawing.Color.White;
            this.btncargarruta.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btncargarruta.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncargarruta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncargarruta.IconSize = 18;
            this.btncargarruta.Location = new System.Drawing.Point(6, 4);
            this.btncargarruta.Name = "btncargarruta";
            this.btncargarruta.Size = new System.Drawing.Size(129, 24);
            this.btncargarruta.TabIndex = 300;
            this.btncargarruta.Text = "Cargar Ruta";
            this.btncargarruta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargarruta.UseVisualStyleBackColor = false;
            this.btncargarruta.Click += new System.EventHandler(this.btncargarruta_Click);
            // 
            // txtlongitud
            // 
            this.txtlongitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlongitud.AutoSize = true;
            this.txtlongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlongitud.Location = new System.Drawing.Point(1079, 17);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(13, 13);
            this.txtlongitud.TabIndex = 295;
            this.txtlongitud.Text = "0";
            // 
            // txtlatitud
            // 
            this.txtlatitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlatitud.AutoSize = true;
            this.txtlatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlatitud.Location = new System.Drawing.Point(917, 17);
            this.txtlatitud.Name = "txtlatitud";
            this.txtlatitud.Size = new System.Drawing.Size(13, 13);
            this.txtlatitud.TabIndex = 294;
            this.txtlatitud.Text = "0";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(874, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 13);
            this.label23.TabIndex = 293;
            this.label23.Text = "Latitud:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1024, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 292;
            this.label16.Text = "Longitud:";
            // 
            // frm_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1213, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Rutas";
            this.Text = "Mantenimiento de Rutas";
            this.Load += new System.EventHandler(this.frm_Rutas_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tbctlrutas.ResumeLayout(false);
            this.tabpgdatosruta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupcargas)).EndInit();
            this.tabpbdatosenvio.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbdetalledestinos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleruta)).EndInit();
            this.gbclientes.ResumeLayout(false);
            this.gbclientes.PerformLayout();
            this.gbdatosvehiculo.ResumeLayout(false);
            this.gbdatosvehiculo.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabpgmapa.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.gbmapa.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnadicionar;
        private FontAwesome.Sharp.IconMenuItem btnguardar;
        private FontAwesome.Sharp.IconMenuItem btnprocesar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtidruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl tbctlrutas;
        private MetroFramework.Controls.MetroTabPage tabpgdatosruta;
        private MetroFramework.Controls.MetroTabPage tabpbdatosenvio;
        private MetroFramework.Controls.MetroTabPage tabpgmapa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpfechaentrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupcargas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboprioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcomentarios;
        private FontAwesome.Sharp.IconMenuItem btneditar;
        private FontAwesome.Sharp.IconMenuItem btnborrar;
        private System.Windows.Forms.TextBox txttiemporuta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbmapa;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private GMap.NET.WindowsForms.GMapControl gMaprutas;
        private FontAwesome.Sharp.IconButton btncargarubicacionactual;
        private System.Windows.Forms.Label txtlongitud;
        private System.Windows.Forms.Label txtlatitud;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttelefono2cliente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttelefonocliente;
        private System.Windows.Forms.GroupBox gbdetalledestinos;
        private MetroFramework.Controls.MetroGrid dgvdetalleruta;
        private System.Windows.Forms.GroupBox gbclientes;
        private System.Windows.Forms.Label label996;
        private System.Windows.Forms.TextBox txtdireccioncliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.GroupBox gbdatosvehiculo;
        private System.Windows.Forms.Label lblidvehiculo;
        private System.Windows.Forms.TextBox txtidvehiculo;
        private FontAwesome.Sharp.IconButton btnbuscarvehiculo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txthabilidadvehiculo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtnombrevehiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtnombreconductor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtemailcliente;
        private FontAwesome.Sharp.IconButton btncargarruta;
        private FontAwesome.Sharp.IconButton btnagregardestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatitudDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongitudDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}