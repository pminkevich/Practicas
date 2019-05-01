using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica_Serializacion
{
    [Serializable]
     class Class1
    {
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Telefono;
        private string _Email;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }

        public Class1()
        {
                
        }
        public Class1(string pNombre,string pApellido, string pDireccion, string pTelefono, string pEmail)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
            this.Email = pEmail;

        }
        public DataTable Cargar(Class1 obj)
        {
            DataTable dt = new DataTable("registro");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("direccion");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Email");
            DataRow fila = dt.NewRow();
            fila["Nombre"] = obj.Nombre;
            fila["Apellido"] = obj.Apellido;
            fila["direccion"] = obj.Direccion;
            fila["Telefono"] = obj.Telefono;
            fila["Email"] = obj.Email;
            dt.Rows.Add(fila);

            return dt;
        }
    }
}
