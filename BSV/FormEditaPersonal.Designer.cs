namespace BSV
{
    partial class FormEditaPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgABM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chBoxCuenta = new System.Windows.Forms.CheckBox();
            this.bttnInactivaEmpleado = new BSV.BotonEditado();
            this.bttnNuevoEmpleado = new BSV.BotonEditado();
            this.bttnActivaEmpleado = new BSV.BotonEditado();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgABM)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgABM
            // 
            this.dtgABM.AllowUserToAddRows = false;
            this.dtgABM.AllowUserToDeleteRows = false;
            this.dtgABM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgABM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgABM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgABM.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgABM.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgABM.Location = new System.Drawing.Point(12, 29);
            this.dtgABM.Name = "dtgABM";
            this.dtgABM.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgABM.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgABM.Size = new System.Drawing.Size(816, 302);
            this.dtgABM.TabIndex = 97;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de ingreso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Código";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Puesto Jerarquico";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 23);
            this.label10.TabIndex = 127;
            this.label10.Text = "Puesto jerarquico:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(451, 401);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(0);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(180, 29);
            this.txtPuesto.TabIndex = 126;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(109, 487);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(0);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 29);
            this.txtDNI.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "Contraseña:";
            this.label5.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(451, 487);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(0);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(180, 29);
            this.txtContraseña.TabIndex = 123;
            this.txtContraseña.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 122;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 121;
            this.label9.Text = "DNI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(109, 443);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(0);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 29);
            this.txtApellido.TabIndex = 120;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(109, 363);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(180, 29);
            this.txtFecha.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(451, 363);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 29);
            this.txtCodigo.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 46);
            this.label1.TabIndex = 115;
            this.label1.Text = "Fecha de \r\ningreso:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(109, 404);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 29);
            this.txtNombre.TabIndex = 114;
            // 
            // chBoxCuenta
            // 
            this.chBoxCuenta.AutoSize = true;
            this.chBoxCuenta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.chBoxCuenta.Location = new System.Drawing.Point(451, 448);
            this.chBoxCuenta.Name = "chBoxCuenta";
            this.chBoxCuenta.Size = new System.Drawing.Size(129, 27);
            this.chBoxCuenta.TabIndex = 143;
            this.chBoxCuenta.Text = "TIene Cuenta";
            this.chBoxCuenta.UseVisualStyleBackColor = true;
            this.chBoxCuenta.CheckedChanged += new System.EventHandler(this.chBoxCuenta_CheckedChanged);
            // 
            // bttnInactivaEmpleado
            // 
            this.bttnInactivaEmpleado.BackColor = System.Drawing.Color.Firebrick;
            this.bttnInactivaEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnInactivaEmpleado.FlatAppearance.BorderSize = 0;
            this.bttnInactivaEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bttnInactivaEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnInactivaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnInactivaEmpleado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnInactivaEmpleado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnInactivaEmpleado.Image = global::BSV.Properties.Resources.borrar;
            this.bttnInactivaEmpleado.Location = new System.Drawing.Point(643, 480);
            this.bttnInactivaEmpleado.Name = "bttnInactivaEmpleado";
            this.bttnInactivaEmpleado.Size = new System.Drawing.Size(197, 65);
            this.bttnInactivaEmpleado.TabIndex = 142;
            this.bttnInactivaEmpleado.Text = "Inactivar";
            this.bttnInactivaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnInactivaEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnInactivaEmpleado.UseVisualStyleBackColor = false;
            // 
            // bttnNuevoEmpleado
            // 
            this.bttnNuevoEmpleado.BackColor = System.Drawing.Color.DarkGreen;
            this.bttnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.bttnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevoEmpleado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnNuevoEmpleado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnNuevoEmpleado.Image = global::BSV.Properties.Resources.archivo_nuevo;
            this.bttnNuevoEmpleado.Location = new System.Drawing.Point(643, 333);
            this.bttnNuevoEmpleado.Name = "bttnNuevoEmpleado";
            this.bttnNuevoEmpleado.Size = new System.Drawing.Size(197, 66);
            this.bttnNuevoEmpleado.TabIndex = 141;
            this.bttnNuevoEmpleado.Text = "Nuevo";
            this.bttnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevoEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnNuevoEmpleado.UseVisualStyleBackColor = false;
            // 
            // bttnActivaEmpleado
            // 
            this.bttnActivaEmpleado.BackColor = System.Drawing.Color.SeaGreen;
            this.bttnActivaEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnActivaEmpleado.Enabled = false;
            this.bttnActivaEmpleado.FlatAppearance.BorderSize = 0;
            this.bttnActivaEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttnActivaEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.bttnActivaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActivaEmpleado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnActivaEmpleado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnActivaEmpleado.Image = global::BSV.Properties.Resources.aprobar;
            this.bttnActivaEmpleado.Location = new System.Drawing.Point(643, 410);
            this.bttnActivaEmpleado.Name = "bttnActivaEmpleado";
            this.bttnActivaEmpleado.Size = new System.Drawing.Size(197, 64);
            this.bttnActivaEmpleado.TabIndex = 140;
            this.bttnActivaEmpleado.Text = "Activar";
            this.bttnActivaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnActivaEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnActivaEmpleado.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(676, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 22);
            this.checkBox1.TabIndex = 144;
            this.checkBox1.Text = "Personal inactivo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormEditaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 539);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chBoxCuenta);
            this.Controls.Add(this.bttnInactivaEmpleado);
            this.Controls.Add(this.bttnNuevoEmpleado);
            this.Controls.Add(this.bttnActivaEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtgABM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditaPersonal";
            this.Text = "FormEditaPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgABM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private BotonEditado bttnNuevoEmpleado;
        private BotonEditado bttnActivaEmpleado;
        private BotonEditado bttnInactivaEmpleado;
        private System.Windows.Forms.CheckBox chBoxCuenta;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}