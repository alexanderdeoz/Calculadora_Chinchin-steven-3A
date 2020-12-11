using System;

namespace Matematica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;

        }

        public int Restar(int sumando1, int sumando2) 
        {
            return sumando1 - sumando2;
        }

        public int Multiplicar(int sumando1, int sumando2)
        {
            return sumando1 * sumando2;
        }

        public int Dividir(int sumando1, int sumando2)
        {
            return sumando1 / sumando2;
        }

        public int Potencia(int sumando1, int sumando2)
        {
            var contador = 0;
            for (var i =0;i<=sumando1;i++) 
            {
                contador = sumando2 * sumando2;
            }
            return contador;
        }

   




    }
}
