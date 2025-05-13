namespace BSV
{
    partial class FormReuniones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblReunion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmBoxAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.dtgReuniones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAreaModif = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnNuevoTarea = new BSV.BotonEditado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonEditado1 = new BSV.BotonEditado();
            this.picBoxInfor = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxBomb = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReuniones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReunion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.lblReunion.Location = new System.Drawing.Point(334, 9);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(176, 43);
            this.lblReunion.TabIndex = 86;
            this.lblReunion.Text = "Reuniones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 85;
            this.label4.Text = "Buscar por área:";
            // 
            // cbmBoxAreas
            // 
            this.cbmBoxAreas.BackColor = System.Drawing.Color.Gainsboro;
            this.cbmBoxAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmBoxAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmBoxAreas.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmBoxAreas.ForeColor = System.Drawing.Color.Black;
            this.cbmBoxAreas.FormattingEnabled = true;
            this.cbmBoxAreas.Location = new System.Drawing.Point(151, 75);
            this.cbmBoxAreas.Name = "cbmBoxAreas";
            this.cbmBoxAreas.Size = new System.Drawing.Size(210, 31);
            this.cbmBoxAreas.TabIndex = 84;
            this.cbmBoxAreas.Text = "Áreas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(414, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 83;
            this.label2.Text = "Buscar por mes:";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(549, 77);
            this.txtMes.Margin = new System.Windows.Forms.Padding(0);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(121, 29);
            this.txtMes.TabIndex = 82;
            // 
            // dtgReuniones
            // 
            this.dtgReuniones.AllowUserToAddRows = false;
            this.dtgReuniones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReuniones.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgReuniones.Location = new System.Drawing.Point(30, 112);
            this.dtgReuniones.Name = "dtgReuniones";
            this.dtgReuniones.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReuniones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgReuniones.Size = new System.Drawing.Size(783, 275);
            this.dtgReuniones.TabIndex = 81;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Hora";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Tema";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 450;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Área";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Bomberos";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbAreaModif
            // 
            this.cmbAreaModif.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbAreaModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAreaModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAreaModif.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaModif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAreaModif.FormattingEnabled = true;
            this.cmbAreaModif.Location = new System.Drawing.Point(524, 413);
            this.cmbAreaModif.Name = "cmbAreaModif";
            this.cmbAreaModif.Size = new System.Drawing.Size(210, 31);
            this.cmbAreaModif.TabIndex = 94;
            this.cmbAreaModif.Text = "Áreas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(361, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 93;
            this.label6.Text = "Tema:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(468, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 92;
            this.label7.Text = "Área:";
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTema.Location = new System.Drawing.Point(433, 471);
            this.txtTema.Margin = new System.Windows.Forms.Padding(0);
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            this.txtTema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTema.Size = new System.Drawing.Size(380, 50);
            this.txtTema.TabIndex = 91;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFecha.Location = new System.Drawing.Point(128, 413);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(132, 29);
            this.txtFecha.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 88;
            this.label5.Text = "Bomberos:";
            // 
            // bttnNuevoTarea
            // 
            this.bttnNuevoTarea.BackColor = System.Drawing.Color.DarkGreen;
            this.bttnNuevoTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNuevoTarea.FlatAppearance.BorderSize = 0;
            this.bttnNuevoTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevoTarea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnNuevoTarea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnNuevoTarea.Image = global::BSV.Properties.Resources.archivo_nuevo;
            this.bttnNuevoTarea.Location = new System.Drawing.Point(418, 524);
            this.bttnNuevoTarea.Name = "bttnNuevoTarea";
            this.bttnNuevoTarea.Size = new System.Drawing.Size(260, 80);
            this.bttnNuevoTarea.TabIndex = 137;
            this.bttnNuevoTarea.Text = "Nuevo";
            this.bttnNuevoTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevoTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnNuevoTarea.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::BSV.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(673, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // botonEditado1
            // 
            this.botonEditado1.BackColor = System.Drawing.Color.Maroon;
            this.botonEditado1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEditado1.FlatAppearance.BorderSize = 0;
            this.botonEditado1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.botonEditado1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.botonEditado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditado1.ForeColor = System.Drawing.Color.White;
            this.botonEditado1.Location = new System.Drawing.Point(263, 393);
            this.botonEditado1.Name = "botonEditado1";
            this.botonEditado1.Size = new System.Drawing.Size(168, 69);
            this.botonEditado1.TabIndex = 139;
            this.botonEditado1.Text = "Agregar Bombero";
            this.botonEditado1.UseVisualStyleBackColor = false;
            // 
            // picBoxInfor
            // 
            this.picBoxInfor.Image = global::BSV.Properties.Resources.informacion;
            this.picBoxInfor.Location = new System.Drawing.Point(266, 470);
            this.picBoxInfor.Name = "picBoxInfor";
            this.picBoxInfor.Size = new System.Drawing.Size(20, 20);
            this.picBoxInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInfor.TabIndex = 146;
            this.picBoxInfor.TabStop = false;
            this.picBoxInfor.MouseEnter += new System.EventHandler(this.picBoxInfor_MouseEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(101, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 145;
            this.label8.Text = "Lista de Bomberos";
            // 
            // listBoxBomb
            // 
            this.listBoxBomb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBomb.FormattingEnabled = true;
            this.listBoxBomb.ItemHeight = 15;
            this.listBoxBomb.Items.AddRange(new object[] {
            "Bombero juan",
            "pepe",
            "lana",
            "maca",
            "elcheche",
            "marco",
            "ari",
            "maco"});
            this.listBoxBomb.Location = new System.Drawing.Point(83, 477);
            this.listBoxBomb.Name = "listBoxBomb";
            this.listBoxBomb.Size = new System.Drawing.Size(177, 79);
            this.listBoxBomb.TabIndex = 144;
            this.listBoxBomb.SelectedIndexChanged += new System.EventHandler(this.listBoxBomb_SelectedIndexChanged);
            // 
            // FormReuniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.picBoxInfor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxBomb);
            this.Controls.Add(this.botonEditado1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnNuevoTarea);
            this.Controls.Add(this.cmbAreaModif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReunion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmBoxAreas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.dtgReuniones);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReuniones";
            this.Text = "FormReuniones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgReuniones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReunion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmBoxAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.DataGridView dtgReuniones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbAreaModif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private BotonEditado bttnNuevoTarea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BotonEditado botonEditado1;
        private System.Windows.Forms.PictureBox picBoxInfor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxBomb;
    }
}