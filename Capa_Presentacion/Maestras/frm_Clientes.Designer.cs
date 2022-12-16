namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    partial class frm_Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.tbctlclientes = new MetroFramework.Controls.MetroTabControl();
            this.tabpginformacion = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabpgrutas = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btncargarrutacliente = new FontAwesome.Sharp.IconButton();
            this.dgv_rutascliente = new MetroFramework.Controls.MetroGrid();
            this.IdRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menubotones.SuspendLayout();
            this.tbctlclientes.SuspendLayout();
            this.tabpginformacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabpgrutas.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutascliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mantenimiento de Clientes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbctlclientes);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 451);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.txtidcliente);
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
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 289;
            this.label11.Text = "IdCliente:";
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
            this.btnbuscar.Location = new System.Drawing.Point(158, 70);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 25);
            this.btnbuscar.TabIndex = 289;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcliente.Location = new System.Drawing.Point(74, 71);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(82, 23);
            this.txtidcliente.TabIndex = 289;
            // 
            // tbctlclientes
            // 
            this.tbctlclientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlclientes.Controls.Add(this.tabpginformacion);
            this.tbctlclientes.Controls.Add(this.tabpgrutas);
            this.tbctlclientes.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbctlclientes.Location = new System.Drawing.Point(3, 110);
            this.tbctlclientes.Name = "tbctlclientes";
            this.tbctlclientes.SelectedIndex = 1;
            this.tbctlclientes.Size = new System.Drawing.Size(924, 336);
            this.tbctlclientes.TabIndex = 3;
            this.tbctlclientes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbctlclientes.UseSelectable = true;
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
            this.tabpginformacion.Size = new System.Drawing.Size(916, 294);
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
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtemailcliente);
            this.panel2.Controls.Add(this.label996);
            this.panel2.Controls.Add(this.txtdireccioncliente);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txttelefono2cliente);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txttelefonocliente);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtnombrecliente);
            this.panel2.Controls.Add(this.cboestado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 295);
            this.panel2.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(7, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 404;
            this.label20.Text = "E-Mail:";
            // 
            // txtemailcliente
            // 
            this.txtemailcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcliente.Location = new System.Drawing.Point(9, 83);
            this.txtemailcliente.Name = "txtemailcliente";
            this.txtemailcliente.Size = new System.Drawing.Size(351, 23);
            this.txtemailcliente.TabIndex = 403;
            // 
            // label996
            // 
            this.label996.AutoSize = true;
            this.label996.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label996.ForeColor = System.Drawing.Color.White;
            this.label996.Location = new System.Drawing.Point(7, 111);
            this.label996.Name = "label996";
            this.label996.Size = new System.Drawing.Size(109, 17);
            this.label996.TabIndex = 402;
            this.label996.Text = "Dirección envio:";
            // 
            // txtdireccioncliente
            // 
            this.txtdireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccioncliente.Location = new System.Drawing.Point(9, 132);
            this.txtdireccioncliente.Name = "txtdireccioncliente";
            this.txtdireccioncliente.Size = new System.Drawing.Size(533, 23);
            this.txtdireccioncliente.TabIndex = 401;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(366, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 398;
            this.label12.Text = "Teléfono 2:";
            // 
            // txttelefono2cliente
            // 
            this.txttelefono2cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono2cliente.Location = new System.Drawing.Point(368, 82);
            this.txttelefono2cliente.Name = "txttelefono2cliente";
            this.txttelefono2cliente.Size = new System.Drawing.Size(174, 23);
            this.txttelefono2cliente.TabIndex = 397;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(366, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 396;
            this.label21.Text = "Teléfono:";
            // 
            // txttelefonocliente
            // 
            this.txttelefonocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonocliente.Location = new System.Drawing.Point(368, 33);
            this.txttelefonocliente.Name = "txttelefonocliente";
            this.txttelefonocliente.Size = new System.Drawing.Size(174, 23);
            this.txttelefonocliente.TabIndex = 395;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(7, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(125, 17);
            this.label22.TabIndex = 400;
            this.label22.Text = "Nombre Completo:";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(9, 33);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(351, 23);
            this.txtnombrecliente.TabIndex = 399;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboestado.Location = new System.Drawing.Point(551, 32);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(127, 24);
            this.cboestado.TabIndex = 301;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 300;
            this.label7.Text = "Estado:";
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
            this.tabpgrutas.Size = new System.Drawing.Size(916, 294);
            this.tabpgrutas.TabIndex = 1;
            this.tabpgrutas.Text = "Historial Entregas";
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
            this.panel4.Controls.Add(this.btncargarrutacliente);
            this.panel4.Controls.Add(this.dgv_rutascliente);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(918, 315);
            this.panel4.TabIndex = 2;
            // 
            // btncargarrutacliente
            // 
            this.btncargarrutacliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btncargarrutacliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncargarrutacliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncargarrutacliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btncargarrutacliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btncargarrutacliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarrutacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btncargarrutacliente.ForeColor = System.Drawing.Color.White;
            this.btncargarrutacliente.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btncargarrutacliente.IconColor = System.Drawing.Color.DodgerBlue;
            this.btncargarrutacliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncargarrutacliente.IconSize = 18;
            this.btncargarrutacliente.Location = new System.Drawing.Point(4, 7);
            this.btncargarrutacliente.Name = "btncargarrutacliente";
            this.btncargarrutacliente.Size = new System.Drawing.Size(129, 24);
            this.btncargarrutacliente.TabIndex = 301;
            this.btncargarrutacliente.Text = "Cargar Rutas";
            this.btncargarrutacliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargarrutacliente.UseVisualStyleBackColor = false;
            this.btncargarrutacliente.Click += new System.EventHandler(this.btncargarrutacliente_Click);
            // 
            // dgv_rutascliente
            // 
            this.dgv_rutascliente.AllowUserToAddRows = false;
            this.dgv_rutascliente.AllowUserToDeleteRows = false;
            this.dgv_rutascliente.AllowUserToResizeRows = false;
            this.dgv_rutascliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rutascliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_rutascliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_rutascliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_rutascliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rutascliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_rutascliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rutascliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRuta,
            this.Titulo,
            this.Concepto,
            this.FechaEntrega,
            this.TiempoRuta,
            this.Cargas,
            this.Comentarios,
            this.Prioridad,
            this.Estado,
            this.FechaRegistro});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rutascliente.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_rutascliente.EnableHeadersVisualStyles = false;
            this.dgv_rutascliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_rutascliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_rutascliente.Location = new System.Drawing.Point(4, 37);
            this.dgv_rutascliente.Name = "dgv_rutascliente";
            this.dgv_rutascliente.ReadOnly = true;
            this.dgv_rutascliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rutascliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_rutascliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_rutascliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_rutascliente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_rutascliente.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_rutascliente.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_rutascliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rutascliente.Size = new System.Drawing.Size(909, 271);
            this.dgv_rutascliente.TabIndex = 2;
            // 
            // IdRuta
            // 
            dataGridViewCellStyle30.Format = "0000";
            this.IdRuta.DefaultCellStyle = dataGridViewCellStyle30;
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
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "Fecha Entrega";
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 140;
            // 
            // TiempoRuta
            // 
            this.TiempoRuta.HeaderText = "Tiempo Estimado";
            this.TiempoRuta.Name = "TiempoRuta";
            this.TiempoRuta.ReadOnly = true;
            this.TiempoRuta.Visible = false;
            this.TiempoRuta.Width = 110;
            // 
            // Cargas
            // 
            this.Cargas.HeaderText = "Cargas";
            this.Cargas.Name = "Cargas";
            this.Cargas.ReadOnly = true;
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
            this.Prioridad.Width = 150;
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
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(938, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Clientes";
            this.Text = "frm_Clientes";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.tbctlclientes.ResumeLayout(false);
            this.tabpginformacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabpgrutas.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutascliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnadicionar;
        private FontAwesome.Sharp.IconMenuItem btnguardar;
        private FontAwesome.Sharp.IconMenuItem btneditar;
        private FontAwesome.Sharp.IconMenuItem btnborrar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtidcliente;
        private MetroFramework.Controls.MetroTabControl tbctlclientes;
        private MetroFramework.Controls.MetroTabPage tabpginformacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTabPage tabpgrutas;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btncargarrutacliente;
        private MetroFramework.Controls.MetroGrid dgv_rutascliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtemailcliente;
        private System.Windows.Forms.Label label996;
        private System.Windows.Forms.TextBox txtdireccioncliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttelefono2cliente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttelefonocliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtnombrecliente;
    }
}