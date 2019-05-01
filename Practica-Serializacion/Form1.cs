using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;


namespace Practica_Serializacion
{
    public partial class Form1 : Form
    {
        private bool IsOK;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                Class1 NuevoReg = new Class1(txtNombre.Text,txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);
                BinaryFormatter formateador = new BinaryFormatter();
                Stream mistream = new FileStream("nuevoreg.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(mistream, NuevoReg);
                mistream.Close();
                MessageBox.Show("objeto serializado");

            }

            

        }
        private void Validar(Form formulario)
        {
            foreach (Control Controles in formulario.Controls)
            {
                if (Controles is TextBox && Controles.Text==string.Empty)
                {
                    errorProvider1.SetError(Controles, "no se ingreso el valor requerido");
                    IsOK = false;
                    
                }
                else
                {
                   IsOK= true;
                }
                
            }
            
           
        }


        private void btnSoap_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                Class1 NuevoReg = new Class1(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text );
                SoapFormatter soapformateador = new SoapFormatter();
                Stream mistream = new FileStream("nuevoregsoap.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                soapformateador.Serialize(mistream, NuevoReg);
                mistream.Close();
                MessageBox.Show("objeto serializado SOAP");


            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream mistream = new FileStream("nuevoreg.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            Class1 miclase = (Class1)formateador.Deserialize(mistream);
            mistream.Close();
            dtgDeserializar.DataSource = miclase.Cargar(miclase);
        }

        private void btnDesSOAP_Click(object sender, EventArgs e)
        {
            SoapFormatter soapformateador = new SoapFormatter();
            Stream mistream = new FileStream("nuevoregsoap.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            Class1 mirecu = (Class1)soapformateador.Deserialize(mistream);
            mistream.Close();
            dtgDeserializar.DataSource = mirecu.Cargar(mirecu);

        }

        private void btnSerXML_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                SerXML miclase = new SerXML();
                miclase.Nombre = txtNombre.Text;
                miclase.Apellido = txtApellido.Text;
                miclase.Direccion = txtDireccion.Text;
                miclase.Telefono = txtTelefono.Text;
                miclase.Email = txtEmail.Text;

                XmlSerializer xmlformateador = new XmlSerializer(typeof(SerXML));
                Stream mistream = new FileStream("regxml.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                xmlformateador.Serialize(mistream, miclase);
                mistream.Close();

                MessageBox.Show("objeto serializado XML");
                                                          
            }
        }

        private void btnDesXML_Click(object sender, EventArgs e)
        {
            XmlSerializer formateadorxml = new XmlSerializer(typeof(SerXML));
            Stream mistream = new FileStream("regxml.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            SerXML miclase = (SerXML)formateadorxml.Deserialize(mistream);
            mistream.Close();
            dtgDeserializar.DataSource = miclase.Cargar(miclase);

        }

        private void btnXML2_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                SerXML miclase = new SerXML();
                TipoUsuario user = new TipoUsuario();

                miclase.Nombre = txtNombre.Text;
                miclase.Apellido = txtApellido.Text;
                miclase.Direccion = txtDireccion.Text;
                miclase.Telefono = txtTelefono.Text;
                miclase.Email = txtEmail.Text;
                user.Usuario = txtUser.Text;
                user.Clave = txtClave.Text;
                miclase.Acesso = user;

                XmlSerializer xmlformateador = new XmlSerializer(typeof(SerXML));
                Stream mistream = new FileStream("regxml2.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                xmlformateador.Serialize(mistream, miclase);
                mistream.Close();

                MessageBox.Show("objeto serializado XML caso 2");

            }
        }

        private void btnDesXML2_Click(object sender, EventArgs e)
        {
            XmlSerializer formateador = new XmlSerializer(typeof(SerXML));
            Stream mistream = new FileStream("regxml.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            SerXML miclase = (SerXML)formateador.Deserialize(mistream);
            mistream.Close();

            dtgDeserializar.DataSource = miclase.Cargar2(miclase);



        }

        private void btnSerBin2_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                SerXML miclase = new SerXML();
                TipoUsuario user = new TipoUsuario();

                miclase.Nombre = txtNombre.Text;
                miclase.Apellido = txtApellido.Text;
                miclase.Direccion = txtDireccion.Text;
                miclase.Telefono = txtTelefono.Text;
                miclase.Email = txtEmail.Text;
                user.Usuario = txtUser.Text;
                user.Clave = txtClave.Text;
                miclase.Acesso = user;
                BinaryFormatter formateador = new BinaryFormatter();
                Stream mistream = new FileStream("nuevoreg2.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(mistream, miclase);
                mistream.Close();
                MessageBox.Show("objeto serializado BIN caso 2");

            }
            

        }

      

        private void btnDesBin2_Click(object sender, EventArgs e)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream mistream = new FileStream("nuevoreg2.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            SerXML miclase = (SerXML)formateador.Deserialize(mistream);
            mistream.Close();
            dtgDeserializar.DataSource = miclase.Cargar2(miclase);
               
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Validar(this);
            if (IsOK)
            {
                SerXML miclase = new SerXML();
                TipoUsuario user = new TipoUsuario();

                miclase.Nombre = txtNombre.Text;
                miclase.Apellido = txtApellido.Text;
                miclase.Direccion = txtDireccion.Text;
                miclase.Telefono = txtTelefono.Text;
                miclase.Email = txtEmail.Text;
                user.Usuario = txtUser.Text;
                user.Clave = txtClave.Text;
                miclase.Acesso = user;
                FileStream Archivo = new FileStream("nuevoarchivo.psm", FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryWriter Writer = new BinaryWriter(Archivo);
                Writer.Write (miclase.Nombre);
                Writer.Write(miclase.Apellido );
                Archivo.Close();

                MessageBox.Show("Archivo Creado");


            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Stream mistream = new FileStream("nuevoarchivo.psm", FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader lector = new BinaryReader(mistream);

            string Nombre = lector.ReadString();
            string Apellido = lector.ReadString();

            MessageBox.Show(string.Format("Hola {0} {1},Bienvenido", Nombre, Apellido));

        }
    }
}
