using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pilales
{
    class PilaLES
    {
        private string[] elementos = new string[0];

        public void Push(string valor)
        {
            Array.Resize(ref elementos, elementos.Length + 1);
            elementos[elementos.Length - 1] = valor;
        }
        public string Pop()
        {
            if (elementos.Length == 0)
            {
                Console.WriteLine("La pila está vacía");
                return null;
            }
            else
            {
                string valor = elementos[elementos.Length - 1];
                Array.Resize(ref elementos, elementos.Length - 1);
                return valor;
            }
        }
        public string Top()
        {
            if (elementos.Length == 0)
            {
                Console.WriteLine("La pila está vacía");
                return null;
            }
            else
            {
                return elementos[elementos.Length - 1];
            }
        }
        public int Size()
        {
            {
                return elementos.Length;
            }
        }
        public bool Empty()
        {
            return elementos.Length == 0;
        }

        public override string? ToString()
        {
            string resultado = "";

            for (int i = 0; i < elementos.Length; i++)
            {
                resultado += elementos[i] + ", ";
            }

            return resultado;
        }
    }
}
