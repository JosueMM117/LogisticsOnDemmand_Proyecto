namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras.frm_Busquedas
{
    partial class frm_BuscarHabilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuscarHabilidades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnquitarfiltro = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbofiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menubotones = new System.Windows.Forms.MenuStrip();
            this.btnexportarexcel = new FontAwesome.Sharp.IconMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvhabilidades = new MetroFramework.Controls.MetroGrid();
            this.IdHabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menubotones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhabilidades)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(552, 65);
            this.panel1.TabIndex = 1;
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
            this.btnquitarfiltro.Location = new System.Drawing.Point(403, 37);
            this.btnquitarfiltro.Name = "btnquitarfiltro";
            this.btnquitarfiltro.Size = new System.Drawing.Size(28, 23);
            this.btnquitarfiltro.TabIndex = 298;
            this.btnquitarfiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquitarfiltro.UseVisualStyleBackColor = true;
            this.btnquitarfiltro.Visible = false;
            this.btnquitarfiltro.Click += new System.EventHandler(this.btnquitarfiltro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(236, 40);
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
            this.txtbusqueda.Size = new System.Drawing.Size(169, 23);
            this.txtbusqueda.TabIndex = 296;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
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
            this.cbofiltro.Location = new System.Drawing.Point(271, 36);
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
            this.label1.Text = "Lista de Habilidades\r\n";
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
            this.menubotones.Size = new System.Drawing.Size(550, 60);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvhabilidades);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 310);
            this.panel2.TabIndex = 2;
            // 
            // dgvhabilidades
            // 
            this.dgvhabilidades.AllowUserToAddRows = false;
            this.dgvhabilidades.AllowUserToDeleteRows = false;
            this.dgvhabilidades.AllowUserToResizeRows = false;
            this.dgvhabilidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhabilidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvhabilidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvhabilidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvhabilidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhabilidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhabilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHabilidad,
            this.Descripcion,
            this.Estado,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhabilidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvhabilidades.EnableHeadersVisualStyles = false;
            this.dgvhabilidades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvhabilidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvhabilidades.Location = new System.Drawing.Point(3, 6);
            this.dgvhabilidades.Name = "dgvhabilidades";
            this.dgvhabilidades.ReadOnly = true;
            this.dgvhabilidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvhabilidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvhabilidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvhabilidades.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvhabilidades.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvhabilidades.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvhabilidades.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvhabilidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhabilidades.Size = new System.Drawing.Size(546, 301);
            this.dgvhabilidades.TabIndex = 1;
            this.dgvhabilidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhabilidades_CellDoubleClick);
            // 
            // IdHabilidad
            // 
            dataGridViewCellStyle2.Format = "000";
            this.IdHabilidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdHabilidad.HeaderText = "IdHabilidad";
            this.IdHabilidad.Name = "IdHabilidad";
            this.IdHabilidad.ReadOnly = true;
            this.IdHabilidad.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
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
            // frm_BuscarHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(552, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BuscarHabilidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Habilidades";
            this.Load += new System.EventHandler(this.frm_BuscarHabilidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menubotones.ResumeLayout(false);
            this.menubotones.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhabilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menubotones;
        private FontAwesome.Sharp.IconMenuItem btnexportarexcel;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid dgvhabilidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbofiltro;
        private FontAwesome.Sharp.IconButton btnquitarfiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}