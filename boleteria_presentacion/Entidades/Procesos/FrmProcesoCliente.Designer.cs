namespace boleteria_presentacion.Entidades.Procesos
{
    partial class FrmProcesoCliente
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
            this.label0 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCI = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(63, 45);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(44, 13);
            this.label0.TabIndex = 0;
            this.label0.Text = "Nombre";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(140, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CI o RUC";
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(140, 96);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(100, 20);
            this.TxtLastname.TabIndex = 6;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(140, 147);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 20);
            this.TxtAge.TabIndex = 7;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(140, 196);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 20);
            this.TxtEmail.TabIndex = 8;
            // 
            // TxtCI
            // 
            this.TxtCI.Location = new System.Drawing.Point(140, 235);
            this.TxtCI.Name = "TxtCI";
            this.TxtCI.Size = new System.Drawing.Size(100, 20);
            this.TxtCI.TabIndex = 9;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(355, 276);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 10;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // FrmProcesoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 311);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtCI);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label0);
            this.Name = "FrmProcesoCliente";
            this.Text = "FrmProcesoCliente";
            this.Load += new System.EventHandler(this.FrmProcesoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCI;
        private System.Windows.Forms.Button BtnAccept;
    }
}