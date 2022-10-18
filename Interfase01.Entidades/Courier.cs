using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public class Courier:Persona,IMensaje
    {
        private string empresa;
        public Courier(string nombre, string apellido, string empresa) : base(nombre, apellido)
        {
            this.empresa = empresa;
        }

        public string Caminar()
        {
            return "Haciendo el reparto";
        }

        public string EnviarMensaje()
        {
            return $"Trabajo en la empresa {empresa} y llevo una carta documento o paquete";
        }
    }
}
