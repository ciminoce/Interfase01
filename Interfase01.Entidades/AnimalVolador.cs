using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public abstract class AnimalVolador
    {
        protected string nombre;

        public AnimalVolador(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
