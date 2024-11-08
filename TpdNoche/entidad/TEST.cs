using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.entidad
{
    internal class TEST
    {
    }

    public class ESemestres
    {
        int id;
        string nombre;

        List<ECurso> cursos;


    }

    public class ECurso
    {
        public int id;
        public string nombre;
        public int sementre_id;

        ESemestres semestres;


    }
}
