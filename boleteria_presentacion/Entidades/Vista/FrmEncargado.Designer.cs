namespace boleteria_presentacion.Entidades.Vista
{
    partial class FrmEncargado
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
            this.DgvEncargado = new System.Windows.Forms.DataGridView();
            this.NewEncargado = new System.Windows.Forms.Button();
            this.EditEncargado = new System.Windows.Forms.Button();
            this.DeleteEncargado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEncargado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEncargado
            // 
            this.DgvEncargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEncargado.Location = new System.Drawing.Point(80, 87);
            this.DgvEncargado.Name = "DgvEncargado";
            this.DgvEncargado.ReadOnly = true;
            this.DgvEncargado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEncargado.Size = new System.Drawing.Size(477, 237);
            this.DgvEncargado.TabIndex = 0;
            // 
            // NewEncargado
            // 
            this.NewEncargado.Location = new System.Drawing.Point(119, 33);
            this.NewEncargado.Name = "NewEncargado";
            this.NewEncargado.Size = new System.Drawing.Size(75, 23);
            this.NewEncargado.TabIndex = 1;
            this.NewEncargado.Text = "Nuevo";
            this.NewEncargado.UseVisualStyleBackColor = true;
            this.NewEncargado.Click += new System.EventHandler(this.NewEncargado_Click);
            // 
            // EditEncargado
            // 
            this.EditEncargado.Location = new System.Drawing.Point(272, 33);
            this.EditEncargado.Name = "EditEncargado";
            this.EditEncargado.Size = new System.Drawing.Size(75, 23);
            this.EditEncargado.TabIndex = 2;
            this.EditEncargado.Text = "Editar";
            this.EditEncargado.UseVisualStyleBackColor = true;
            this.EditEncargado.Click += new System.EventHandler(this.EditEncargado_Click);
            // 
            // DeleteEncargado
            // 
            this.DeleteEncargado.Location = new System.Drawing.Point(439, 33);
            this.DeleteEncargado.Name = "DeleteEncargado";
            this.DeleteEncargado.Size = new System.Drawing.Size(75, 23);
            this.DeleteEncargado.TabIndex = 3;
            this.DeleteEncargado.Text = "Eliminar";
            this.DeleteEncargado.UseVisualStyleBackColor = true;
            this.DeleteEncargado.Click += new System.EventHandler(this.DeleteEncargado_Click);
            // 
            // FrmEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.DeleteEncargado);
            this.Controls.Add(this.EditEncargado);
            this.Controls.Add(this.NewEncargado);
            this.Controls.Add(this.DgvEncargado);
            this.Name = "FrmEncargado";
            this.Text = "FrmEncargado";
            this.Load += new System.EventHandler(this.FrmEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEncargado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEncargado;
        private System.Windows.Forms.Button NewEncargado;
        private System.Windows.Forms.Button EditEncargado;
        private System.Windows.Forms.Button DeleteEncargado;
    }
}