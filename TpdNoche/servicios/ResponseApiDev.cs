using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdNoche.entidad;

namespace TpdNoche.servicios
{
    public class ResponseApiDev<T>
    {
        private bool success; 
        private T data;

        public bool Success { get => success; set => success = value; }
        public T Data { get => data; set => data = value; }
    }

}
