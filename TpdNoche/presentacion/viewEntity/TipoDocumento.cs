using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.presentacion.viewEntity
{
    public class TipoDocumento
    {
        private List<ETipoDocuemto> list;

        public TipoDocumento() { 
            list=new List<ETipoDocuemto>();

            list.Add(new ETipoDocuemto() { Id = 1,Descripcion="DNI" }); 
            list.Add(new ETipoDocuemto() { Id = 6,Descripcion="RUC" }); 
        
        }

        public List<ETipoDocuemto> List { get => list; set => list = value; }

        public void addDoc(ETipoDocuemto doc)
        {
            list.Add(doc);
        }
    }

    public class ETipoDocuemto
    {
        int id;
        string descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
