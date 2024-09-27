using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdNoche.entidad;
using TpdNoche.modelo;

namespace TpdNoche.negocio
{
    public class NUser
    {
        private UserModel model;

        public NUser()
        {
            model = new UserModel();
        }

        public int Insert(EUser data)
        {
            return model.Create(data);
        }
        public List<EUser> ReadAll()
        {
            return model.ReadAll();
        }
        public int Update(EUser data)
        {
            return model.Update(data);
        }
        public int Delete(EUser data)
        {
            return model.Delete(data);
        }


    }
}
