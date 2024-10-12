using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdNoche.entidad;
using TpdNoche.modelo;

namespace TpdNoche.negocio
{
    public class NProducto
    {
        ProductoModelo modelo;
        public NProducto() { 
            modelo = new ProductoModelo();
        }


        public int Create(EProducto data)
        {
            return modelo.Create(data);
        }

        public List<EProducto> ReadAll()
        {
            return modelo.ReadAll();
        }
    }
}
