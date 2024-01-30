namespace boleteria_presentacion
{
    partial class Form1
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
            this.CmbMain = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbMain
            // 
            this.CmbMain.FormattingEnabled = true;
            this.CmbMain.Items.AddRange(new object[] {
            "Cliente"});
            this.CmbMain.Location = new System.Drawing.Point(147, 58);
            this.CmbMain.Name = "CmbMain";
            this.CmbMain.Size = new System.Drawing.Size(121, 21);
            this.CmbMain.TabIndex = 0;
            this.CmbMain.SelectedIndexChanged += new System.EventHandler(this.CmbMain_Selected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 155);
            this.Controls.Add(this.CmbMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMain;
    }
}

