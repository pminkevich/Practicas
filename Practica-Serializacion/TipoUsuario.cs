using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Serializacion
{
    [Serializable]
    public class TipoUsuario
    {
        private string _Usuario;
        private string _Clave;
        private string _TipoUser;

        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string TipoUser { get => _TipoUser; set => _TipoUser = value; }
    }
}
