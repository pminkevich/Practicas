namespace WindowsFormsApp1
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
            this.btnPasarDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPasarDec
            // 
            this.btnPasarDec.Location = new System.Drawing.Point(106, 88);
            this.btnPasarDec.Name = "btnPasarDec";
            this.btnPasarDec.Size = new System.Drawing.Size(148, 23);
            this.btnPasarDec.TabIndex = 0;
            this.btnPasarDec.Text = "Pasar a Decimal";
            this.btnPasarDec.UseVisualStyleBackColor = true;
            this.btnPasarDec.Click += new System.EventHandler(this.btnPasarDec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Binario";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(126, 62);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(100, 20);
            this.txtBin.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPasarDec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasarDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBin;
    }
}

