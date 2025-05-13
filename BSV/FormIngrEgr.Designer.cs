namespace BSV
{
    partial class FormIngrEgr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAsistArea = new System.Windows.Forms.Label();
            this.txtFiltNA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHsEntra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnModifHs = new BSV.BotonEditado();
            this.picBoxInfor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y Apellido";
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Fecha";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HS. Entrada";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "HS. Salida";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "HS. Entrada";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "HS. Salida";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "HS. Entrada ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "HS. Salida";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "HS. Entrada";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "HS. Salida";
            this.Column9.Name = "Column9";
            // 
            // lblAsistArea
            // 
            this.lblAsistArea.AutoSize = true;
            this.lblAsistArea.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.lblAsistArea.Location = new System.Drawing.Point(256, 9);
            this.lblAsistArea.Name = "lblAsistArea";
            this.lblAsistArea.Size = new System.Drawing.Size(263, 43);
            this.lblAsistArea.TabIndex = 118;
            this.lblAsistArea.Text = "Asistencia Diaria";
            // 
            // txtFiltNA
            // 
            this.txtFiltNA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltNA.Location = new System.Drawing.Point(264, 67);
            this.txtFiltNA.Margin = new System.Windows.Forms.Padding(0);
            this.txtFiltNA.Name = "txtFiltNA";
            this.txtFiltNA.Size = new System.Drawing.Size(255, 29);
            this.txtFiltNA.TabIndex = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 119;
            this.label1.Text = "Buscar por Nombre y Apellido:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(680, 494);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 29);
            this.dateTimePicker1.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 122;
            this.label2.Text = "HS. Salida:";
            // 
            // txtNA
            // 
            this.txtNA.Enabled = false;
            this.txtNA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNA.Location = new System.Drawing.Point(168, 494);
            this.txtNA.Margin = new System.Windows.Forms.Padding(0);
            this.txtNA.Name = "txtNA";
            this.txtNA.Size = new System.Drawing.Size(211, 29);
            this.txtNA.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 123;
            this.label3.Text = "Nombre y Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 125;
            this.label4.Text = "HS. Entrada:";
            // 
            // txtHsEntra
            // 
            this.txtHsEntra.Enabled = false;
            this.txtHsEntra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsEntra.Location = new System.Drawing.Point(488, 494);
            this.txtHsEntra.Margin = new System.Windows.Forms.Padding(0);
            this.txtHsEntra.Name = "txtHsEntra";
            this.txtHsEntra.Size = new System.Drawing.Size(93, 29);
            this.txtHsEntra.TabIndex = 126;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::BSV.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(522, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // bttnModifHs
            // 
            this.bttnModifHs.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttnModifHs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnModifHs.FlatAppearance.BorderSize = 0;
            this.bttnModifHs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple;
            this.bttnModifHs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnModifHs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModifHs.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnModifHs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnModifHs.Image = global::BSV.Properties.Resources.reloj;
            this.bttnModifHs.Location = new System.Drawing.Point(264, 526);
            this.bttnModifHs.Name = "bttnModifHs";
            this.bttnModifHs.Size = new System.Drawing.Size(260, 80);
            this.bttnModifHs.TabIndex = 127;
            this.bttnModifHs.Text = "Modificar ";
            this.bttnModifHs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnModifHs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnModifHs.UseVisualStyleBackColor = false;
            // 
            // picBoxInfor
            // 
            this.picBoxInfor.Image = global::BSV.Properties.Resources.informacion;
            this.picBoxInfor.Location = new System.Drawing.Point(522, 543);
            this.picBoxInfor.Name = "picBoxInfor";
            this.picBoxInfor.Size = new System.Drawing.Size(20, 20);
            this.picBoxInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInfor.TabIndex = 144;
            this.picBoxInfor.TabStop = false;
            this.picBoxInfor.MouseEnter += new System.EventHandler(this.picBoxInfor_MouseEnter);
            // 
            // FormIngrEgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.picBoxInfor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnModifHs);
            this.Controls.Add(this.txtHsEntra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFiltNA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAsistArea);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngrEgr";
            this.Text = "FormIngrEgr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAsistArea;
        private System.Windows.Forms.TextBox txtFiltNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHsEntra;
        private BotonEditado bttnModifHs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxInfor;
    }
}