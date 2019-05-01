using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Practica_Serializacion
{
    [Serializable]
   public class SerXML
    {
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private TipoUsuario _Acesso;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public TipoUsuario Acesso { get => _Acesso; set => _Acesso = value; }

        public SerXML()
        {

        }

        public DataTable Cargar(SerXML obj)
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
        public DataTable Cargar2(SerXML obj)
        {
            DataTable dt = new DataTable("registro");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("direccion");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Email");
            dt.Columns.Add("Usuario");
            dt.Columns.Add("Clave");

            DataRow fila = dt.NewRow();
            fila["Nombre"] = obj.Nombre;
            fila["Apellido"] = obj.Apellido;
            fila["direccion"] = obj.Direccion;
            fila["Telefono"] = obj.Telefono;
            fila["Email"] = obj.Email;
            fila["Usuario"] = obj.Acesso.Usuario;
            fila["Clave"] = obj.Acesso.Clave;
            dt.Rows.Add(fila);

            return dt;
        }
    }
}
