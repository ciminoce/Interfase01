using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfase01.Entidades;

namespace Interfase01.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Courier c = new Courier("Mrs", "Postman", "OCA");
            Console.WriteLine(c.EnviarMensaje());
            Paloma p = new Paloma("Plumita", "Rivendel");
            Console.WriteLine(p.EnviarMensaje());
            Carta carta = new Carta(100, 140, 2);
            Console.WriteLine(carta.EnviarMensaje());
            Cuervo cuervo = new Cuervo("Corvacho");
            Console.WriteLine(cuervo.EnviarMensaje());
            Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());
            //Codigo agregado
            List<IMensaje> lista = new List<IMensaje>();
            lista.Add(c);
            lista.Add(p);
            lista.Add(carta);
            lista.Add(cuervo);
            foreach (var mensajero in lista)
            {
                Console.WriteLine(mensajero.EnviarMensaje());
                if (mensajero is Cuervo cur)
                {
                    Console.WriteLine(((IEncriptado)cur).EnviarMensaje());
                }
            }

            Console.ReadLine();
        }
    }
}
