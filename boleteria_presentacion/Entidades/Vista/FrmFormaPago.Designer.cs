namespace boleteria_presentacion.Entidades.Vista
{
    partial class FrmFormaPago
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
            this.DgvFormaPago = new System.Windows.Forms.DataGridView();
            this.BtnNuevoFormaPago = new System.Windows.Forms.Button();
            this.BtnEditFormaPago = new System.Windows.Forms.Button();
            this.BtnEliminarFormaPago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFormaPago
            // 
            this.DgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFormaPago.Location = new System.Drawing.Point(45, 67);
            this.DgvFormaPago.Name = "DgvFormaPago";
            this.DgvFormaPago.ReadOnly = true;
            this.DgvFormaPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFormaPago.Size = new System.Drawing.Size(306, 198);
            this.DgvFormaPago.TabIndex = 0;
            // 
            // BtnNuevoFormaPago
            // 
            this.BtnNuevoFormaPago.Location = new System.Drawing.Point(45, 23);
            this.BtnNuevoFormaPago.Name = "BtnNuevoFormaPago";
            this.BtnNuevoFormaPago.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevoFormaPago.TabIndex = 1;
            this.BtnNuevoFormaPago.Text = "Nuevo";
            this.BtnNuevoFormaPago.UseVisualStyleBackColor = true;
            this.BtnNuevoFormaPago.Click += new System.EventHandler(this.BtnNuevoFormaPago_Click);
            // 
            // BtnEditFormaPago
            // 
            this.BtnEditFormaPago.Location = new System.Drawing.Point(163, 23);
            this.BtnEditFormaPago.Name = "BtnEditFormaPago";
            this.BtnEditFormaPago.Size = new System.Drawing.Size(75, 23);
            this.BtnEditFormaPago.TabIndex = 2;
            this.BtnEditFormaPago.Text = "Editar";
            this.BtnEditFormaPago.UseVisualStyleBackColor = true;
            this.BtnEditFormaPago.Click += new System.EventHandler(this.BtnEditFormaPago_Click);
            // 
            // BtnEliminarFormaPago
            // 
            this.BtnEliminarFormaPago.Location = new System.Drawing.Point(276, 23);
            this.BtnEliminarFormaPago.Name = "BtnEliminarFormaPago";
            this.BtnEliminarFormaPago.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarFormaPago.TabIndex = 3;
            this.BtnEliminarFormaPago.Text = "Eliminar";
            this.BtnEliminarFormaPago.UseVisualStyleBackColor = true;
            this.BtnEliminarFormaPago.Click += new System.EventHandler(this.BtnEliminarFormaPago_Click);
            // 
            // FrmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 299);
            this.Controls.Add(this.BtnEliminarFormaPago);
            this.Controls.Add(this.BtnEditFormaPago);
            this.Controls.Add(this.BtnNuevoFormaPago);
            this.Controls.Add(this.DgvFormaPago);
            this.Name = "FrmFormaPago";
            this.Text = "FrmFormaPago";
            this.Load += new System.EventHandler(this.FrmFormaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFormaPago;
        private System.Windows.Forms.Button BtnNuevoFormaPago;
        private System.Windows.Forms.Button BtnEditFormaPago;
        private System.Windows.Forms.Button BtnEliminarFormaPago;
    }
}