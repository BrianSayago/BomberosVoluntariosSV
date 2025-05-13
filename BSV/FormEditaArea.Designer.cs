namespace BSV
{
    partial class FormEditaArea
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
            this.dtgvAreasDispo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblÁrea = new System.Windows.Forms.Label();
            this.bttnNuevoTarea = new BSV.BotonEditado();
            this.bttnEliminaTarea = new BSV.BotonEditado();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAreasDispo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAreasDispo
            // 
            this.dtgvAreasDispo.AllowUserToAddRows = false;
            this.dtgvAreasDispo.AllowUserToDeleteRows = false;
            this.dtgvAreasDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAreasDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgvAreasDispo.Location = new System.Drawing.Point(129, 31);
            this.dtgvAreasDispo.Name = "dtgvAreasDispo";
            this.dtgvAreasDispo.ReadOnly = true;
            this.dtgvAreasDispo.Size = new System.Drawing.Size(543, 333);
            this.dtgvAreasDispo.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Areas Funcionales";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 500;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(267, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 29);
            this.textBox1.TabIndex = 5;
            // 
            // lblÁrea
            // 
            this.lblÁrea.AutoSize = true;
            this.lblÁrea.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblÁrea.Location = new System.Drawing.Point(211, 388);
            this.lblÁrea.Name = "lblÁrea";
            this.lblÁrea.Size = new System.Drawing.Size(50, 23);
            this.lblÁrea.TabIndex = 4;
            this.lblÁrea.Text = "Área:";
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
            this.bttnNuevoTarea.Location = new System.Drawing.Point(421, 462);
            this.bttnNuevoTarea.Name = "bttnNuevoTarea";
            this.bttnNuevoTarea.Size = new System.Drawing.Size(261, 80);
            this.bttnNuevoTarea.TabIndex = 139;
            this.bttnNuevoTarea.Text = "Nuevo";
            this.bttnNuevoTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevoTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnNuevoTarea.UseVisualStyleBackColor = false;
            // 
            // bttnEliminaTarea
            // 
            this.bttnEliminaTarea.BackColor = System.Drawing.Color.Maroon;
            this.bttnEliminaTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEliminaTarea.FlatAppearance.BorderSize = 0;
            this.bttnEliminaTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminaTarea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.bttnEliminaTarea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnEliminaTarea.Image = global::BSV.Properties.Resources.marca_x;
            this.bttnEliminaTarea.Location = new System.Drawing.Point(129, 462);
            this.bttnEliminaTarea.Name = "bttnEliminaTarea";
            this.bttnEliminaTarea.Size = new System.Drawing.Size(261, 80);
            this.bttnEliminaTarea.TabIndex = 138;
            this.bttnEliminaTarea.Text = "Eliminar";
            this.bttnEliminaTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminaTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnEliminaTarea.UseVisualStyleBackColor = false;
            // 
            // FormEditaArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 541);
            this.Controls.Add(this.bttnNuevoTarea);
            this.Controls.Add(this.bttnEliminaTarea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblÁrea);
            this.Controls.Add(this.dtgvAreasDispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditaArea";
            this.Text = "FormEditaArea";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAreasDispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAreasDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblÁrea;
        private BotonEditado bttnNuevoTarea;
        private BotonEditado bttnEliminaTarea;
    }
}