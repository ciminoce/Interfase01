using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public class Paloma:AnimalVolador,IMensaje
    {
        private string destino;
        public Paloma(string nombre, string destino) : base(nombre)
        {
            this.destino = destino;
        }

        public string Volar()
        {
            return "Volando por los cielos";
        }

        public string EnviarMensaje()
        {
            return $"Enviando un mensaje a {destino}";
        }
    }
}
