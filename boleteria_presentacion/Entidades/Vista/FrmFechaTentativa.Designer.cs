namespace boleteria_presentacion.Entidades.Vista
{
    partial class FrmFechaTentativa
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
            this.DgvFechaTentativa = new System.Windows.Forms.DataGridView();
            this.NewDate = new System.Windows.Forms.Button();
            this.EditDate = new System.Windows.Forms.Button();
            this.DeleteDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFechaTentativa)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFechaTentativa
            // 
            this.DgvFechaTentativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFechaTentativa.Location = new System.Drawing.Point(107, 88);
            this.DgvFechaTentativa.Name = "DgvFechaTentativa";
            this.DgvFechaTentativa.ReadOnly = true;
            this.DgvFechaTentativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFechaTentativa.Size = new System.Drawing.Size(342, 191);
            this.DgvFechaTentativa.TabIndex = 0;
            // 
            // NewDate
            // 
            this.NewDate.Location = new System.Drawing.Point(107, 41);
            this.NewDate.Name = "NewDate";
            this.NewDate.Size = new System.Drawing.Size(75, 23);
            this.NewDate.TabIndex = 1;
            this.NewDate.Text = "Nuevo";
            this.NewDate.UseVisualStyleBackColor = true;
            this.NewDate.Click += new System.EventHandler(this.NewDate_Click);
            // 
            // EditDate
            // 
            this.EditDate.Location = new System.Drawing.Point(237, 41);
            this.EditDate.Name = "EditDate";
            this.EditDate.Size = new System.Drawing.Size(75, 23);
            this.EditDate.TabIndex = 2;
            this.EditDate.Text = "Editar";
            this.EditDate.UseVisualStyleBackColor = true;
            this.EditDate.Click += new System.EventHandler(this.EditDate_Click);
            // 
            // DeleteDate
            // 
            this.DeleteDate.Location = new System.Drawing.Point(374, 41);
            this.DeleteDate.Name = "DeleteDate";
            this.DeleteDate.Size = new System.Drawing.Size(75, 23);
            this.DeleteDate.TabIndex = 3;
            this.DeleteDate.Text = "Eliminar";
            this.DeleteDate.UseVisualStyleBackColor = true;
            this.DeleteDate.Click += new System.EventHandler(this.DeleteDate_Click);
            // 
            // FrmFechaTentativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 317);
            this.Controls.Add(this.DeleteDate);
            this.Controls.Add(this.EditDate);
            this.Controls.Add(this.NewDate);
            this.Controls.Add(this.DgvFechaTentativa);
            this.Name = "FrmFechaTentativa";
            this.Text = "FrmFechaTentativa";
            this.Load += new System.EventHandler(this.FrmFechaTentativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFechaTentativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFechaTentativa;
        private System.Windows.Forms.Button NewDate;
        private System.Windows.Forms.Button EditDate;
        private System.Windows.Forms.Button DeleteDate;
    }
}