namespace Problemas
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
            this.txtConsola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPares = new System.Windows.Forms.Button();
            this.txtCeroalCien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMultiplos3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMuestraNum = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSumayMul = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsola
            // 
            this.txtConsola.Location = new System.Drawing.Point(156, 30);
            this.txtConsola.Multiline = true;
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsola.Size = new System.Drawing.Size(469, 369);
            this.txtConsola.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Impares";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(23, 77);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(116, 30);
            this.txtPares.TabIndex = 2;
            this.txtPares.Text = "Pares";
            this.txtPares.UseVisualStyleBackColor = true;
            this.txtPares.Click += new System.EventHandler(this.txtPares_Click);
            // 
            // txtCeroalCien
            // 
            this.txtCeroalCien.Location = new System.Drawing.Point(23, 126);
            this.txtCeroalCien.Name = "txtCeroalCien";
            this.txtCeroalCien.Size = new System.Drawing.Size(116, 29);
            this.txtCeroalCien.TabIndex = 3;
            this.txtCeroalCien.Text = "De Cero Al Cien";
            this.txtCeroalCien.UseVisualStyleBackColor = true;
            this.txtCeroalCien.Click += new System.EventHandler(this.txtCeroalCien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "De Cien a Cero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMultiplos3
            // 
            this.txtMultiplos3.Location = new System.Drawing.Point(23, 213);
            this.txtMultiplos3.Name = "txtMultiplos3";
            this.txtMultiplos3.Size = new System.Drawing.Size(116, 28);
            this.txtMultiplos3.TabIndex = 5;
            this.txtMultiplos3.Text = "Multiplos de 3";
            this.txtMultiplos3.UseVisualStyleBackColor = true;
            this.txtMultiplos3.Click += new System.EventHandler(this.txtMultiplos3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(658, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ingrese Un Numero Para Sumar los Anteriores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMuestraNum
            // 
            this.txtMuestraNum.Location = new System.Drawing.Point(659, 107);
            this.txtMuestraNum.Name = "txtMuestraNum";
            this.txtMuestraNum.Size = new System.Drawing.Size(113, 62);
            this.txtMuestraNum.TabIndex = 6;
            this.txtMuestraNum.Text = "Ingrese Un Numero Para Mostrar los Anteriores";
            this.txtMuestraNum.UseVisualStyleBackColor = true;
            this.txtMuestraNum.Click += new System.EventHandler(this.txtMuestraNum_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ingrese Un Numero Para Mostrar los Multiplos de 3, hasta el numero ingresado ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Numeros Primos del 1 Al 100";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSumayMul
            // 
            this.btnSumayMul.Location = new System.Drawing.Point(659, 259);
            this.btnSumayMul.Name = "btnSumayMul";
            this.btnSumayMul.Size = new System.Drawing.Size(113, 62);
            this.btnSumayMul.TabIndex = 6;
            this.btnSumayMul.Text = "Ingrese 10 Numeros Para Sumarlos Y Multiplicarlos";
            this.btnSumayMul.UseVisualStyleBackColor = true;
            this.btnSumayMul.Click += new System.EventHandler(this.btnSumayMul_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(25, 315);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(116, 39);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(658, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "Mostrar el cuadrado y cubo de un numero";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 371);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 42);
            this.button7.TabIndex = 8;
            this.button7.Text = "LINQ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSumayMul);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMuestraNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtMultiplos3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCeroalCien);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtPares;
        private System.Windows.Forms.Button txtCeroalCien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtMultiplos3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button txtMuestraNum;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSumayMul;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

