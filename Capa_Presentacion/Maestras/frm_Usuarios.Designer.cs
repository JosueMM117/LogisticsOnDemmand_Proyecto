namespace LogisticsOnDemmand_Proyecto.Capa_Presentacion.Maestras
{
    partial class frm_Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnrutas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maestra de Usuarios";
            // 
            // btnrutas
            // 
            this.btnrutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrutas.AutoSize = true;
            this.btnrutas.FlatAppearance.BorderSize = 0;
            this.btnrutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrutas.ForeColor = System.Drawing.Color.Black;
            this.btnrutas.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btnrutas.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnrutas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrutas.IconSize = 36;
            this.btnrutas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrutas.Location = new System.Drawing.Point(716, 3);
            this.btnrutas.Name = "btnrutas";
            this.btnrutas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnrutas.Size = new System.Drawing.Size(195, 43);
            this.btnrutas.TabIndex = 2;
            this.btnrutas.Text = "Abrir Nuevo Nodo";
            this.btnrutas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnrutas.UseVisualStyleBackColor = true;
            this.btnrutas.Click += new System.EventHandler(this.btnrutas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnrutas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 407);
            this.panel1.TabIndex = 3;
            // 
            // frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Usuarios";
            this.Text = "frm_Usuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnrutas;
        private System.Windows.Forms.Panel panel1;
    }
}