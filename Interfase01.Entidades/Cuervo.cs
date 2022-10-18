using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfase01.Entidades
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(string nombre) : base(nombre)
        {
        }

        public string EnviarMensaje()
        {
            return "Enviando un mensaje desde la Torre de Londres";
        }

        string IEncriptado.EnviarMensaje()
        {
            string texto = "Enviando un mensaje desde la Torre de Londres";
            SHA256 sha256 = SHA256Managed.Create();
            Encoding encoding = Encoding.UTF8;
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(texto));
            foreach (var t in stream)
                sb.AppendFormat("{0:x2}", t);

            return sb.ToString();



        }
    }
}
