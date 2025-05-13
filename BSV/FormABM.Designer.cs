namespace BSV
{
    partial class FormABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABM));
            this.panelEditar = new System.Windows.Forms.Panel();
            this.pbLogoPag = new System.Windows.Forms.PictureBox();
            this.bttnEditaArea = new System.Windows.Forms.Button();
            this.bttnEditaPersonal = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPag)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditar
            // 
            this.panelEditar.AutoSize = true;
            this.panelEditar.BackColor = System.Drawing.Color.LightGray;
            this.panelEditar.Controls.Add(this.pbLogoPag);
            this.panelEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditar.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelEditar.Location = new System.Drawing.Point(0, 66);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(840, 539);
            this.panelEditar.TabIndex = 102;
            // 
            // pbLogoPag
            // 
            this.pbLogoPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogoPag.Enabled = false;
            this.pbLogoPag.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPag.Image")));
            this.pbLogoPag.Location = new System.Drawing.Point(161, 49);
            this.pbLogoPag.Name = "pbLogoPag";
            this.pbLogoPag.Size = new System.Drawing.Size(492, 386);
            this.pbLogoPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoPag.TabIndex = 103;
            this.pbLogoPag.TabStop = false;
            // 
            // bttnEditaArea
            // 
            this.bttnEditaArea.BackColor = System.Drawing.Color.Transparent;
            this.bttnEditaArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEditaArea.FlatAppearance.BorderSize = 0;
            this.bttnEditaArea.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.bttnEditaArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnEditaArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnEditaArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEditaArea.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold);
            this.bttnEditaArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttnEditaArea.Location = new System.Drawing.Point(12, 7);
            this.bttnEditaArea.Name = "bttnEditaArea";
            this.bttnEditaArea.Size = new System.Drawing.Size(211, 53);
            this.bttnEditaArea.TabIndex = 98;
            this.bttnEditaArea.Text = "Editar Áreas";
            this.bttnEditaArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEditaArea.UseVisualStyleBackColor = false;
            this.bttnEditaArea.Click += new System.EventHandler(this.bttnAreas_Click);
            // 
            // bttnEditaPersonal
            // 
            this.bttnEditaPersonal.BackColor = System.Drawing.Color.Transparent;
            this.bttnEditaPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEditaPersonal.FlatAppearance.BorderSize = 0;
            this.bttnEditaPersonal.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.bttnEditaPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttnEditaPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttnEditaPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEditaPersonal.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold);
            this.bttnEditaPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.bttnEditaPersonal.Location = new System.Drawing.Point(229, 7);
            this.bttnEditaPersonal.Name = "bttnEditaPersonal";
            this.bttnEditaPersonal.Size = new System.Drawing.Size(258, 53);
            this.bttnEditaPersonal.TabIndex = 97;
            this.bttnEditaPersonal.Text = "Editar Personal";
            this.bttnEditaPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEditaPersonal.UseVisualStyleBackColor = false;
            this.bttnEditaPersonal.Click += new System.EventHandler(this.bttnPersonal_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.LightGray;
            this.panelBarra.Controls.Add(this.bttnEditaPersonal);
            this.panelBarra.Controls.Add(this.bttnEditaArea);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(840, 66);
            this.panelBarra.TabIndex = 101;
            // 
            // FormABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormABM";
            this.Text = "FormABM";
            this.panelEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPag)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.PictureBox pbLogoPag;
        private System.Windows.Forms.Button bttnEditaArea;
        private System.Windows.Forms.Button bttnEditaPersonal;
        private System.Windows.Forms.Panel panelBarra;
    }
}