namespace BSV
{
    partial class FormTareasI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTareasI));
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.lblTareas = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.txtLegajos = new System.Windows.Forms.TextBox();
            this.picBoxLinea3 = new System.Windows.Forms.PictureBox();
            this.picBoxLinea1 = new System.Windows.Forms.PictureBox();
            this.picBoxLinea = new System.Windows.Forms.PictureBox();
            this.chkBoxColabora = new System.Windows.Forms.CheckBox();
            this.bttnG = new BSV.BotonEditado();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.PanelBarraTitulo.Controls.Add(this.iconminimizar);
            this.PanelBarraTitulo.Controls.Add(this.iconcerrar);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(900, 45);
            this.PanelBarraTitulo.TabIndex = 3;
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(830, 3);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(26, 26);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 12;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(861, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(26, 26);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 9;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.lblTareas.Location = new System.Drawing.Point(369, 48);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(141, 42);
            this.lblTareas.TabIndex = 64;
            this.lblTareas.Text = "Tareas";
            // 
            // txtTarea
            // 
            this.txtTarea.BackColor = System.Drawing.Color.White;
            this.txtTarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtTarea.Location = new System.Drawing.Point(102, 227);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(723, 29);
            this.txtTarea.TabIndex = 70;
            this.txtTarea.TabStop = false;
            this.txtTarea.Text = "TAREAS";
            // 
            // cmbAreas
            // 
            this.cmbAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(377, 146);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(256, 33);
            this.cmbAreas.TabIndex = 69;
            this.cmbAreas.TabStop = false;
            this.cmbAreas.Text = "LISTA DE AREAS";
            // 
            // txtLegajos
            // 
            this.txtLegajos.BackColor = System.Drawing.Color.White;
            this.txtLegajos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLegajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtLegajos.Location = new System.Drawing.Point(102, 146);
            this.txtLegajos.Multiline = true;
            this.txtLegajos.Name = "txtLegajos";
            this.txtLegajos.Size = new System.Drawing.Size(198, 29);
            this.txtLegajos.TabIndex = 1;
            this.txtLegajos.TabStop = false;
            this.txtLegajos.Text = "CÓDIGO";
            // 
            // picBoxLinea3
            // 
            this.picBoxLinea3.BackColor = System.Drawing.Color.DimGray;
            this.picBoxLinea3.Location = new System.Drawing.Point(102, 258);
            this.picBoxLinea3.Name = "picBoxLinea3";
            this.picBoxLinea3.Size = new System.Drawing.Size(723, 2);
            this.picBoxLinea3.TabIndex = 68;
            this.picBoxLinea3.TabStop = false;
            // 
            // picBoxLinea1
            // 
            this.picBoxLinea1.BackColor = System.Drawing.Color.DimGray;
            this.picBoxLinea1.Location = new System.Drawing.Point(102, 177);
            this.picBoxLinea1.Name = "picBoxLinea1";
            this.picBoxLinea1.Size = new System.Drawing.Size(198, 2);
            this.picBoxLinea1.TabIndex = 66;
            this.picBoxLinea1.TabStop = false;
            // 
            // picBoxLinea
            // 
            this.picBoxLinea.BackColor = System.Drawing.Color.DimGray;
            this.picBoxLinea.Location = new System.Drawing.Point(379, 179);
            this.picBoxLinea.Name = "picBoxLinea";
            this.picBoxLinea.Size = new System.Drawing.Size(254, 2);
            this.picBoxLinea.TabIndex = 67;
            this.picBoxLinea.TabStop = false;
            // 
            // chkBoxColabora
            // 
            this.chkBoxColabora.AutoSize = true;
            this.chkBoxColabora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.chkBoxColabora.Location = new System.Drawing.Point(654, 150);
            this.chkBoxColabora.Name = "chkBoxColabora";
            this.chkBoxColabora.Size = new System.Drawing.Size(158, 29);
            this.chkBoxColabora.TabIndex = 71;
            this.chkBoxColabora.Text = "Colaboración";
            this.chkBoxColabora.UseVisualStyleBackColor = true;
            // 
            // bttnG
            // 
            this.bttnG.BackColor = System.Drawing.Color.Maroon;
            this.bttnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnG.FlatAppearance.BorderSize = 0;
            this.bttnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnG.ForeColor = System.Drawing.Color.White;
            this.bttnG.Location = new System.Drawing.Point(318, 292);
            this.bttnG.Name = "bttnG";
            this.bttnG.Size = new System.Drawing.Size(260, 80);
            this.bttnG.TabIndex = 76;
            this.bttnG.Text = "GUARDAR";
            this.bttnG.UseVisualStyleBackColor = false;
            this.bttnG.Click += new System.EventHandler(this.bttnG_Click);
            // 
            // FormTareasI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 380);
            this.Controls.Add(this.bttnG);
            this.Controls.Add(this.chkBoxColabora);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.cmbAreas);
            this.Controls.Add(this.txtLegajos);
            this.Controls.Add(this.picBoxLinea3);
            this.Controls.Add(this.picBoxLinea1);
            this.Controls.Add(this.picBoxLinea);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.PanelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTareasI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTareasI";
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.TextBox txtLegajos;
        private System.Windows.Forms.PictureBox picBoxLinea3;
        private System.Windows.Forms.PictureBox picBoxLinea1;
        private System.Windows.Forms.PictureBox picBoxLinea;
        private System.Windows.Forms.CheckBox chkBoxColabora;
        private BotonEditado bttnG;
    }
}