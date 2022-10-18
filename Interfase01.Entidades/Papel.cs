using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public abstract class Papel
    {
        protected int ancho;
        protected int largo;

        public Papel(int ancho, int largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
    }
}
