namespace boleteria_presentacion.Entidades.Procesos
{
    partial class FrmProcesoSala
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumeroSala = new System.Windows.Forms.TextBox();
            this.TxtBloque = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bloque";
            // 
            // TxtNumeroSala
            // 
            this.TxtNumeroSala.Location = new System.Drawing.Point(133, 81);
            this.TxtNumeroSala.Name = "TxtNumeroSala";
            this.TxtNumeroSala.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroSala.TabIndex = 2;
            // 
            // TxtBloque
            // 
            this.TxtBloque.Location = new System.Drawing.Point(133, 135);
            this.TxtBloque.Name = "TxtBloque";
            this.TxtBloque.Size = new System.Drawing.Size(100, 20);
            this.TxtBloque.TabIndex = 3;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(253, 226);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmProcesoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 329);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtBloque);
            this.Controls.Add(this.TxtNumeroSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProcesoSala";
            this.Text = "FrmProcesoSala";
            this.Load += new System.EventHandler(this.FrmProcesoSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumeroSala;
        private System.Windows.Forms.TextBox TxtBloque;
        private System.Windows.Forms.Button BtnAceptar;
    }
}