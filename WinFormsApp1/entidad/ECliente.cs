using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.entidad
{
    public class ECliente
    {
        private int id,tipo_documento,estado;
        private string nombre, telefono, nrodoc, direccion, email;

        public ECliente()
        {
        }

        public ECliente(int id, int tipo_documento, int estado, string nombre, string telefono, string nrodoc, string direccion, string email)
        {
            this.id = id;
            this.tipo_documento = tipo_documento;
            this.estado = estado;
            this.nombre = nombre;
            this.telefono = telefono;
            this.nrodoc = nrodoc;
            this.direccion = direccion;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public int Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nrodoc { get => nrodoc; set => nrodoc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
    }
}
