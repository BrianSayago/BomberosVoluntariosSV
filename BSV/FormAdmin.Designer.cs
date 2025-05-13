namespace BSV
{
    partial class FormAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panel_Min_Cerrar = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.panelC = new System.Windows.Forms.Panel();
            this.pbLogoPag = new System.Windows.Forms.PictureBox();
            this.panel_Barra_Vertical = new System.Windows.Forms.Panel();
            this.bttnIngEgr = new System.Windows.Forms.Button();
            this.bttnSalir = new BSV.BotonEditado();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.bntTareas = new System.Windows.Forms.Button();
            this.btnAsistInstitu = new System.Windows.Forms.Button();
            this.bttn_AsistenciaAreas = new System.Windows.Forms.Button();
            this.bttn_ABM = new System.Windows.Forms.Button();
            this.bttn_Reuniones = new System.Windows.Forms.Button();
            this.panel_Min_Cerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPag)).BeginInit();
            this.panel_Barra_Vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Min_Cerrar
            // 
            this.panel_Min_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel_Min_Cerrar.Controls.Add(this.iconminimizar);
            this.panel_Min_Cerrar.Controls.Add(this.iconcerrar);
            this.panel_Min_Cerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Min_Cerrar.Location = new System.Drawing.Point(0, 0);
            this.panel_Min_Cerrar.Name = "panel_Min_Cerrar";
            this.panel_Min_Cerrar.Size = new System.Drawing.Size(1100, 45);
            this.panel_Min_Cerrar.TabIndex = 4;
            this.panel_Min_Cerrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Min_Cerrar_MouseDown_1);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconminimizar.Image")));
            this.iconminimizar.Location = new System.Drawing.Point(1021, 3);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(26, 26);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 14;
            this.iconminimizar.TabStop = false;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(1062, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(26, 26);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 13;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            // 
            // panelC
            // 
            this.panelC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelC.AutoScroll = true;
            this.panelC.AutoSize = true;
            this.panelC.BackColor = System.Drawing.Color.LightGray;
            this.panelC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelC.Controls.Add(this.pbLogoPag);
            this.panelC.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelC.Location = new System.Drawing.Point(260, 45);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(840, 605);
            this.panelC.TabIndex = 6;
            // 
            // pbLogoPag
            // 
            this.pbLogoPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogoPag.Enabled = false;
            this.pbLogoPag.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPag.Image")));
            this.pbLogoPag.Location = new System.Drawing.Point(142, 62);
            this.pbLogoPag.Name = "pbLogoPag";
            this.pbLogoPag.Size = new System.Drawing.Size(581, 451);
            this.pbLogoPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoPag.TabIndex = 103;
            this.pbLogoPag.TabStop = false;
            this.pbLogoPag.Click += new System.EventHandler(this.pbLogoPag_Click);
            // 
            // panel_Barra_Vertical
            // 
            this.panel_Barra_Vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel_Barra_Vertical.Controls.Add(this.bttnIngEgr);
            this.panel_Barra_Vertical.Controls.Add(this.bttnSalir);
            this.panel_Barra_Vertical.Controls.Add(this.btnMenu);
            this.panel_Barra_Vertical.Controls.Add(this.bntTareas);
            this.panel_Barra_Vertical.Controls.Add(this.btnAsistInstitu);
            this.panel_Barra_Vertical.Controls.Add(this.bttn_AsistenciaAreas);
            this.panel_Barra_Vertical.Controls.Add(this.bttn_ABM);
            this.panel_Barra_Vertical.Controls.Add(this.bttn_Reuniones);
            this.panel_Barra_Vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Barra_Vertical.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Barra_Vertical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.panel_Barra_Vertical.Location = new System.Drawing.Point(0, 45);
            this.panel_Barra_Vertical.Name = "panel_Barra_Vertical";
            this.panel_Barra_Vertical.Size = new System.Drawing.Size(260, 605);
            this.panel_Barra_Vertical.TabIndex = 5;
            // 
            // bttnIngEgr
            // 
            this.bttnIngEgr.BackColor = System.Drawing.Color.Transparent;
            this.bttnIngEgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnIngEgr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttnIngEgr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.bttnIngEgr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttnIngEgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnIngEgr.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnIngEgr.ForeColor = System.Drawing.Color.White;
            this.bttnIngEgr.Image = global::BSV.Properties.Resources.calendario;
            this.bttnIngEgr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnIngEgr.Location = new System.Drawing.Point(8, 291);
            this.bttnIngEgr.Name = "bttnIngEgr";
            this.bttnIngEgr.Size = new System.Drawing.Size(253, 70);
            this.bttnIngEgr.TabIndex = 17;
            this.bttnIngEgr.Text = "  Ingreso/Egreso";
            this.bttnIngEgr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnIngEgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnIngEgr.UseVisualStyleBackColor = false;
            this.bttnIngEgr.Click += new System.EventHandler(this.bttnIngEgr_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(16)))));
            this.bttnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSalir.FlatAppearance.BorderSize = 0;
            this.bttnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(207)))), ((int)(((byte)(69)))));
            this.bttnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(16)))));
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold);
            this.bttnSalir.ForeColor = System.Drawing.Color.White;
            this.bttnSalir.Image = global::BSV.Properties.Resources.boton_salir_a_la_aplicacion;
            this.bttnSalir.Location = new System.Drawing.Point(89, 537);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(172, 68);
            this.bttnSalir.TabIndex = 6;
            this.bttnSalir.Text = " Salir";
            this.bttnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(214, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 16;
            this.btnMenu.TabStop = false;
            // 
            // bntTareas
            // 
            this.bntTareas.BackColor = System.Drawing.Color.Transparent;
            this.bntTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntTareas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bntTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.bntTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bntTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntTareas.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTareas.ForeColor = System.Drawing.Color.White;
            this.bntTareas.Image = global::BSV.Properties.Resources.lista_de_verificacion;
            this.bntTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTareas.Location = new System.Drawing.Point(8, 215);
            this.bntTareas.Name = "bntTareas";
            this.bntTareas.Size = new System.Drawing.Size(253, 70);
            this.bntTareas.TabIndex = 14;
            this.bntTareas.Text = "  Tareas";
            this.bntTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntTareas.UseVisualStyleBackColor = false;
            this.bntTareas.Click += new System.EventHandler(this.bntTareas_Click);
            // 
            // btnAsistInstitu
            // 
            this.btnAsistInstitu.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistInstitu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistInstitu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.btnAsistInstitu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnAsistInstitu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnAsistInstitu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistInstitu.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistInstitu.ForeColor = System.Drawing.Color.White;
            this.btnAsistInstitu.Image = global::BSV.Properties.Resources.lista_de_tareas;
            this.btnAsistInstitu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistInstitu.Location = new System.Drawing.Point(8, 133);
            this.btnAsistInstitu.Name = "btnAsistInstitu";
            this.btnAsistInstitu.Size = new System.Drawing.Size(252, 76);
            this.btnAsistInstitu.TabIndex = 13;
            this.btnAsistInstitu.Text = "  Asistencia a     \r\n  Institución";
            this.btnAsistInstitu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistInstitu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsistInstitu.UseVisualStyleBackColor = false;
            this.btnAsistInstitu.Click += new System.EventHandler(this.btnAsistInstitu_Click);
            // 
            // bttn_AsistenciaAreas
            // 
            this.bttn_AsistenciaAreas.BackColor = System.Drawing.Color.Transparent;
            this.bttn_AsistenciaAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_AsistenciaAreas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttn_AsistenciaAreas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.bttn_AsistenciaAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttn_AsistenciaAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_AsistenciaAreas.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_AsistenciaAreas.ForeColor = System.Drawing.Color.White;
            this.bttn_AsistenciaAreas.Image = global::BSV.Properties.Resources.contrato;
            this.bttn_AsistenciaAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_AsistenciaAreas.Location = new System.Drawing.Point(7, 57);
            this.bttn_AsistenciaAreas.Name = "bttn_AsistenciaAreas";
            this.bttn_AsistenciaAreas.Size = new System.Drawing.Size(253, 70);
            this.bttn_AsistenciaAreas.TabIndex = 12;
            this.bttn_AsistenciaAreas.Text = "  Asistencia a Área";
            this.bttn_AsistenciaAreas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_AsistenciaAreas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttn_AsistenciaAreas.UseVisualStyleBackColor = false;
            this.bttn_AsistenciaAreas.Click += new System.EventHandler(this.bttn_AsistenciaAreas_Click);
            // 
            // bttn_ABM
            // 
            this.bttn_ABM.BackColor = System.Drawing.Color.Transparent;
            this.bttn_ABM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_ABM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttn_ABM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.bttn_ABM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttn_ABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_ABM.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_ABM.ForeColor = System.Drawing.Color.White;
            this.bttn_ABM.Image = global::BSV.Properties.Resources.llave_inglesag;
            this.bttn_ABM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_ABM.Location = new System.Drawing.Point(7, 443);
            this.bttn_ABM.Name = "bttn_ABM";
            this.bttn_ABM.Size = new System.Drawing.Size(253, 70);
            this.bttn_ABM.TabIndex = 9;
            this.bttn_ABM.Text = "  Editar";
            this.bttn_ABM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttn_ABM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttn_ABM.UseVisualStyleBackColor = false;
            this.bttn_ABM.Click += new System.EventHandler(this.bttn_ABM_Click);
            // 
            // bttn_Reuniones
            // 
            this.bttn_Reuniones.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Reuniones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Reuniones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttn_Reuniones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.bttn_Reuniones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.bttn_Reuniones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Reuniones.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Reuniones.ForeColor = System.Drawing.Color.White;
            this.bttn_Reuniones.Image = global::BSV.Properties.Resources.trabajo_en_equipo;
            this.bttn_Reuniones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Reuniones.Location = new System.Drawing.Point(8, 367);
            this.bttn_Reuniones.Name = "bttn_Reuniones";
            this.bttn_Reuniones.Size = new System.Drawing.Size(253, 70);
            this.bttn_Reuniones.TabIndex = 8;
            this.bttn_Reuniones.Text = "  Reuniones de\r\n  área";
            this.bttn_Reuniones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttn_Reuniones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttn_Reuniones.UseVisualStyleBackColor = false;
            this.bttn_Reuniones.Click += new System.EventHandler(this.bttn_Reuniones_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panel_Barra_Vertical);
            this.Controls.Add(this.panel_Min_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.panel_Min_Cerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panelC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPag)).EndInit();
            this.panel_Barra_Vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Min_Cerrar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Button bttn_Reuniones;
        private System.Windows.Forms.Button bttn_ABM;
        private System.Windows.Forms.Button bttn_AsistenciaAreas;
        private System.Windows.Forms.Button btnAsistInstitu;
        private System.Windows.Forms.Button bntTareas;
        private System.Windows.Forms.PictureBox btnMenu;
        private BotonEditado bttnSalir;
        private System.Windows.Forms.Panel panel_Barra_Vertical;
        private System.Windows.Forms.Button bttnIngEgr;
        private System.Windows.Forms.PictureBox pbLogoPag;
    }
}