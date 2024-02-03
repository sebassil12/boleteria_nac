namespace boleteria_presentacion.Entidades.Procesos
{
    partial class FrmProcesoEstreno
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSinopsis = new System.Windows.Forms.TextBox();
            this.TxtFechaTentativa = new System.Windows.Forms.TextBox();
            this.TxtTrailer = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinopsis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Tentativa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trailer";
            // 
            // TxtSinopsis
            // 
            this.TxtSinopsis.Location = new System.Drawing.Point(217, 67);
            this.TxtSinopsis.Name = "TxtSinopsis";
            this.TxtSinopsis.Size = new System.Drawing.Size(100, 20);
            this.TxtSinopsis.TabIndex = 3;
            // 
            // TxtFechaTentativa
            // 
            this.TxtFechaTentativa.Location = new System.Drawing.Point(217, 126);
            this.TxtFechaTentativa.Name = "TxtFechaTentativa";
            this.TxtFechaTentativa.Size = new System.Drawing.Size(100, 20);
            this.TxtFechaTentativa.TabIndex = 4;
            // 
            // TxtTrailer
            // 
            this.TxtTrailer.Location = new System.Drawing.Point(217, 188);
            this.TxtTrailer.Name = "TxtTrailer";
            this.TxtTrailer.Size = new System.Drawing.Size(100, 20);
            this.TxtTrailer.TabIndex = 5;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(290, 268);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmProcesoEstreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtTrailer);
            this.Controls.Add(this.TxtFechaTentativa);
            this.Controls.Add(this.TxtSinopsis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProcesoEstreno";
            this.Text = "FrmProcesoEstreno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSinopsis;
        private System.Windows.Forms.TextBox TxtFechaTentativa;
        private System.Windows.Forms.TextBox TxtTrailer;
        private System.Windows.Forms.Button BtnAceptar;
    }
}