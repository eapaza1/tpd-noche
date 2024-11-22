using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.servicios
{
    public class DataDniResponse
    {
        
        private string numero, nombre_completo,nombres;
        private string apellido_paterno, apellido_materno;
        private int codigo_verificacion;
        private string ubigeo_sunat;
        private string direccion;

        public string Numero { get => numero; set => numero = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public int Codigo_verificacion { get => codigo_verificacion; set => codigo_verificacion = value; }
        public string Ubigeo_sunat { get => ubigeo_sunat; set => ubigeo_sunat = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombres { get => nombres; set => nombres = value; }
    }
}
