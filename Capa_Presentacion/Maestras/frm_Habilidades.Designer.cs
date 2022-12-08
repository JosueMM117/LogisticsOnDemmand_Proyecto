namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    partial class frm_Habilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Habilidades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menubotones = new System.Windows.Forms.MenuStrip();
            this.btnadicionar = new FontAwesome.Sharp.IconMenuItem();
            this.btnguardar = new FontAwesome.Sharp.IconMenuItem();
            this.btneditar = new FontAwesome.Sharp.IconMenuItem();
            this.btnborrar = new FontAwesome.Sharp.IconMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtidhabilidad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menubotones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboestado);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Location = new System.Drawing.Point(1, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 154);
            this.panel1.TabIndex = 0;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboestado.Location = new System.Drawing.Point(5, 78);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(127, 24);
            this.cboestado.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(5, 31);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(351, 23);
            this.txtdescripcion.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.menubotones);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 64);
            this.panel5.TabIndex = 291;
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
            this.menubotones.Size = new System.Drawing.Size(526, 62);
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
            this.btnadicionar.Size = new System.Drawing.Size(71, 58);
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
            this.btnguardar.Size = new System.Drawing.Size(64, 58);
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
            this.btneditar.Size = new System.Drawing.Size(52, 58);
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
            this.btnborrar.Size = new System.Drawing.Size(55, 58);
            this.btnborrar.Text = "Borrar";
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 292;
            this.label11.Text = "IdHabilidad:";
            // 
            // txtidhabilidad
            // 
            this.txtidhabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidhabilidad.Location = new System.Drawing.Point(87, 67);
            this.txtidhabilidad.Name = "txtidhabilidad";
            this.txtidhabilidad.Size = new System.Drawing.Size(82, 23);
            this.txtidhabilidad.TabIndex = 294;
            this.txtidhabilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidhabilidad_KeyDown);
            this.txtidhabilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidhabilidad_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtidhabilidad);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 96);
            this.panel2.TabIndex = 295;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnbuscar.Location = new System.Drawing.Point(171, 66);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 25);
            this.btnbuscar.TabIndex = 293;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frm_Habilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(528, 254);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Habilidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mentenimiento de Habilidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Habilidades_FormClosing);
            this.Load += new System.EventHandler(this.frm_Habilidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnadicionar;
        private FontAwesome.Sharp.IconMenuItem btnguardar;
        private FontAwesome.Sharp.IconMenuItem btneditar;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtidhabilidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconMenuItem btnborrar;
    }
}