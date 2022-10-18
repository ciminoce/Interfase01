using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public class Carta:Papel,IMensaje
    {
        private int cantidadHojas;
        public Carta(int ancho, int largo, int cantidad) : base(ancho, largo)
        {
            cantidadHojas = cantidad;
        }

        public string EnviarMensaje()
        {
            return $"Una carta escrita en {cantidadHojas} hojas";
        }
    }
}
