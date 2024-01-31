namespace boleteria_presentacion.Entidades.Procesos
{
    partial class FrmProcesoEncargado
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
            this.Apellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreEncargado = new System.Windows.Forms.TextBox();
            this.TxtApellidoEncargado = new System.Windows.Forms.TextBox();
            this.BtnEncargado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(81, 135);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(0, 13);
            this.Apellido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // TxtNombreEncargado
            // 
            this.TxtNombreEncargado.Location = new System.Drawing.Point(188, 60);
            this.TxtNombreEncargado.Name = "TxtNombreEncargado";
            this.TxtNombreEncargado.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreEncargado.TabIndex = 3;
            // 
            // TxtApellidoEncargado
            // 
            this.TxtApellidoEncargado.Location = new System.Drawing.Point(188, 135);
            this.TxtApellidoEncargado.Name = "TxtApellidoEncargado";
            this.TxtApellidoEncargado.Size = new System.Drawing.Size(100, 20);
            this.TxtApellidoEncargado.TabIndex = 4;
            // 
            // BtnEncargado
            // 
            this.BtnEncargado.Location = new System.Drawing.Point(357, 255);
            this.BtnEncargado.Name = "BtnEncargado";
            this.BtnEncargado.Size = new System.Drawing.Size(75, 23);
            this.BtnEncargado.TabIndex = 5;
            this.BtnEncargado.Text = "Aceptar";
            this.BtnEncargado.UseVisualStyleBackColor = true;
            this.BtnEncargado.Click += new System.EventHandler(this.BtnEncargado_Click);
            // 
            // FrmProcesoEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 328);
            this.Controls.Add(this.BtnEncargado);
            this.Controls.Add(this.TxtApellidoEncargado);
            this.Controls.Add(this.TxtNombreEncargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label1);
            this.Name = "FrmProcesoEncargado";
            this.Text = "t";
            this.Load += new System.EventHandler(this.FrmProcesoEncargado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreEncargado;
        private System.Windows.Forms.TextBox TxtApellidoEncargado;
        private System.Windows.Forms.Button BtnEncargado;
    }
}