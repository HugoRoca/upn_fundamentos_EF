namespace upn_fundamentos_EF.Enunciado1
{
    partial class FrmEnunciado1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnunciado1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtOrdenado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada:";
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(101, 17);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(401, 22);
            this.txtArray.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(98, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Separe por comas \",\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Array Normal:";
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(101, 76);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.ReadOnly = true;
            this.txtNormal.Size = new System.Drawing.Size(401, 22);
            this.txtNormal.TabIndex = 4;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(328, 45);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(84, 25);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Ordenar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Location = new System.Drawing.Point(418, 45);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(84, 25);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtOrdenado
            // 
            this.txtOrdenado.Location = new System.Drawing.Point(101, 105);
            this.txtOrdenado.Name = "txtOrdenado";
            this.txtOrdenado.ReadOnly = true;
            this.txtOrdenado.Size = new System.Drawing.Size(401, 22);
            this.txtOrdenado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Array Ordenado:";
            // 
            // FrmEnunciado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 139);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrdenado);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNormal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEnunciado1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado 1 - Arrays - Recursividad";
            this.Load += new System.EventHandler(this.FrmEnunciado1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtOrdenado;
        private System.Windows.Forms.Label label4;
    }
}