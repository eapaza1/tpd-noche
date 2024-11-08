using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdNoche.entidad;
using TpdNoche.modelo;

namespace TpdNoche.negocio
{
    public class NVenta
    {
        VentaModelo modelo;
        public NVenta() { 
            modelo = new VentaModelo();
        }

        public int Create(EVenta data)
        {
            return modelo.Create(data);
        }

        /*
        public List<ECliente> ReadAll()
        {
            return modelo.ReadAll();
        }

        public int Update(ECliente data)
        {
            return modelo.Update(data);
        }
        public int Delete(ECliente data)
        {
            return modelo.Delete(data);
        }
        */
    }
}
