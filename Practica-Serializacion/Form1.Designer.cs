namespace Practica_Serializacion
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.dtgDeserializar = new System.Windows.Forms.DataGridView();
            this.btnDes = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDesSOAP = new System.Windows.Forms.Button();
            this.btnSoap = new System.Windows.Forms.Button();
            this.btnSerXML = new System.Windows.Forms.Button();
            this.btnDesXML = new System.Windows.Forms.Button();
            this.btnXML2 = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDesXML2 = new System.Windows.Forms.Button();
            this.btnDesBin2 = new System.Windows.Forms.Button();
            this.btnSerBin2 = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeserializar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 132);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(126, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(85, 158);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(126, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(73, 219);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(150, 30);
            this.btnSerializar.TabIndex = 5;
            this.btnSerializar.Text = "Serializar BIN";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // dtgDeserializar
            // 
            this.dtgDeserializar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDeserializar.Location = new System.Drawing.Point(240, 29);
            this.dtgDeserializar.Name = "dtgDeserializar";
            this.dtgDeserializar.Size = new System.Drawing.Size(390, 150);
            this.dtgDeserializar.TabIndex = 3;
            // 
            // btnDes
            // 
            this.btnDes.Location = new System.Drawing.Point(283, 200);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(291, 30);
            this.btnDes.TabIndex = 6;
            this.btnDes.Text = "Deserializar y recuperar a datagrid BIN";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EMAIL";
            // 
            // btnDesSOAP
            // 
            this.btnDesSOAP.Location = new System.Drawing.Point(283, 236);
            this.btnDesSOAP.Name = "btnDesSOAP";
            this.btnDesSOAP.Size = new System.Drawing.Size(291, 30);
            this.btnDesSOAP.TabIndex = 6;
            this.btnDesSOAP.Text = "Deserializar y recuperar a datagrid SOAP";
            this.btnDesSOAP.UseVisualStyleBackColor = true;
            this.btnDesSOAP.Click += new System.EventHandler(this.btnDesSOAP_Click);
            // 
            // btnSoap
            // 
            this.btnSoap.Location = new System.Drawing.Point(73, 255);
            this.btnSoap.Name = "btnSoap";
            this.btnSoap.Size = new System.Drawing.Size(150, 30);
            this.btnSoap.TabIndex = 5;
            this.btnSoap.Text = "Serializar SOAP";
            this.btnSoap.UseVisualStyleBackColor = true;
            this.btnSoap.Click += new System.EventHandler(this.btnSoap_Click);
            // 
            // btnSerXML
            // 
            this.btnSerXML.Location = new System.Drawing.Point(73, 291);
            this.btnSerXML.Name = "btnSerXML";
            this.btnSerXML.Size = new System.Drawing.Size(150, 30);
            this.btnSerXML.TabIndex = 5;
            this.btnSerXML.Text = "Serializar XML";
            this.btnSerXML.UseVisualStyleBackColor = true;
            this.btnSerXML.Click += new System.EventHandler(this.btnSerXML_Click);
            // 
            // btnDesXML
            // 
            this.btnDesXML.Location = new System.Drawing.Point(283, 272);
            this.btnDesXML.Name = "btnDesXML";
            this.btnDesXML.Size = new System.Drawing.Size(291, 30);
            this.btnDesXML.TabIndex = 6;
            this.btnDesXML.Text = "Deserializar y recuperar a datagrid XML";
            this.btnDesXML.UseVisualStyleBackColor = true;
            this.btnDesXML.Click += new System.EventHandler(this.btnDesXML_Click);
            // 
            // btnXML2
            // 
            this.btnXML2.Location = new System.Drawing.Point(73, 359);
            this.btnXML2.Name = "btnXML2";
            this.btnXML2.Size = new System.Drawing.Size(150, 30);
            this.btnXML2.TabIndex = 5;
            this.btnXML2.Text = "Serializar XML caso 2";
            this.btnXML2.UseVisualStyleBackColor = true;
            this.btnXML2.Click += new System.EventHandler(this.btnXML2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(126, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 52);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(126, 20);
            this.txtClave.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "USUARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "CLAVE";
            // 
            // btnDesXML2
            // 
            this.btnDesXML2.Location = new System.Drawing.Point(283, 344);
            this.btnDesXML2.Name = "btnDesXML2";
            this.btnDesXML2.Size = new System.Drawing.Size(291, 30);
            this.btnDesXML2.TabIndex = 6;
            this.btnDesXML2.Text = "Deserializar y recuperar a datagrid XML caso 2";
            this.btnDesXML2.UseVisualStyleBackColor = true;
            this.btnDesXML2.Click += new System.EventHandler(this.btnDesXML2_Click);
            // 
            // btnDesBin2
            // 
            this.btnDesBin2.Location = new System.Drawing.Point(283, 308);
            this.btnDesBin2.Name = "btnDesBin2";
            this.btnDesBin2.Size = new System.Drawing.Size(291, 30);
            this.btnDesBin2.TabIndex = 6;
            this.btnDesBin2.Text = "Deserializar y recuperar a datagrid BIN 2";
            this.btnDesBin2.UseVisualStyleBackColor = true;
            this.btnDesBin2.Click += new System.EventHandler(this.btnDesBin2_Click);
            // 
            // btnSerBin2
            // 
            this.btnSerBin2.Location = new System.Drawing.Point(73, 323);
            this.btnSerBin2.Name = "btnSerBin2";
            this.btnSerBin2.Size = new System.Drawing.Size(150, 30);
            this.btnSerBin2.TabIndex = 5;
            this.btnSerBin2.Text = "Serializar BIN 2";
            this.btnSerBin2.UseVisualStyleBackColor = true;
            this.btnSerBin2.Click += new System.EventHandler(this.btnSerBin2_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(73, 401);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 37);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "Crear Archivo";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(308, 387);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(249, 34);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDeserializar);
            this.Controls.Add(this.btnDesXML2);
            this.Controls.Add(this.btnDesXML);
            this.Controls.Add(this.btnDesSOAP);
            this.Controls.Add(this.btnDesBin2);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.btnXML2);
            this.Controls.Add(this.btnSerXML);
            this.Controls.Add(this.btnSoap);
            this.Controls.Add(this.btnSerBin2);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDeserializar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.DataGridView dtgDeserializar;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesSOAP;
        private System.Windows.Forms.Button btnSoap;
        private System.Windows.Forms.Button btnDesXML;
        private System.Windows.Forms.Button btnSerXML;
        private System.Windows.Forms.Button btnXML2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnDesXML2;
        private System.Windows.Forms.Button btnDesBin2;
        private System.Windows.Forms.Button btnSerBin2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAbrir;
    }
}

