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
            data.Password = hashPassword(data.Password);
            return model.Create(data);
        }

        public List<EUser> ReadAll()
        {
            return model.ReadAll();
        }
        public int Update(EUser data)
        {
            if (data.Password!="")
            {
                data.Password = hashPassword(data.Password);
            }
            else
            {
                EUser user = model.FindById(data.Id);
                data.Password=user.Password;
            }          

            return model.Update(data);
        }
        public int Delete(EUser data)
        {
            return model.Delete(data);
        }

        

        private string hashPassword(string password)
        {
            string hash = "";

            hash=BCrypt.Net.BCrypt.HashPassword(password,workFactor:10);

            return hash;

        }

        public string login(string username, string password)
        {
            EUser usuario= model.FindByUsername(username);

            if (usuario.Username != null)
            {
                //usuario verificado
                //password==usuario.Password
                if(BCrypt.Net.BCrypt.Verify(password,usuario.Password))
                {
                    return "exito";
                }
                else
                {
                    return "password incorrecto";
                }
            }
            else
            {
                return "usuario incorrecto";
            }
        }
    }
}
