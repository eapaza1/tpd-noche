using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.presentacion.viewEntity
{
   
    public class EstadoCliente
    {
        List<EEstadoCliente> estados;

        public EstadoCliente()
        {
            estados = new List<EEstadoCliente>();
            estados.Add(new EEstadoCliente() { Id = 0, Descripcion = "INACTIVO" });
            estados.Add(new EEstadoCliente() { Id = 1, Descripcion = "ACTIVO" });
        }

        public List<EEstadoCliente> Estados { get => estados; set => estados = value; }
    }

    public class EEstadoCliente
    {
        int id;
        string descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
