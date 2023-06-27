namespace upn_fundamentos_EF
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnunciado2 = new System.Windows.Forms.Button();
            this.btnEnunciado1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::upn_fundamentos_EF.Properties.Resources.upn_sede;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnunciado2
            // 
            this.btnEnunciado2.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEnunciado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnunciado2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnunciado2.Location = new System.Drawing.Point(202, 144);
            this.btnEnunciado2.Name = "btnEnunciado2";
            this.btnEnunciado2.Size = new System.Drawing.Size(135, 60);
            this.btnEnunciado2.TabIndex = 1;
            this.btnEnunciado2.Text = "Enunciado 2";
            this.btnEnunciado2.UseVisualStyleBackColor = false;
            // 
            // btnEnunciado1
            // 
            this.btnEnunciado1.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEnunciado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnunciado1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnunciado1.Location = new System.Drawing.Point(61, 144);
            this.btnEnunciado1.Name = "btnEnunciado1";
            this.btnEnunciado1.Size = new System.Drawing.Size(135, 60);
            this.btnEnunciado1.TabIndex = 0;
            this.btnEnunciado1.Text = "Enunciado 1";
            this.btnEnunciado1.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 241);
            this.Controls.Add(this.btnEnunciado1);
            this.Controls.Add(this.btnEnunciado2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnunciado2;
        private System.Windows.Forms.Button btnEnunciado1;
    }
}

