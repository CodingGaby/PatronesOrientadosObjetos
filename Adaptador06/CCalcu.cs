using System;

namespace Adaptador06
{
    class CCalcu : ITarget
    {
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }

        public int Restar(int pA, int pB)
        {
            return pA - pB;
        }

        public int Multiplicar(int pA, int pB)
        {
            return pA * pB;
        }

        public int Dividir(int pA, int pB)
        {
            if (pB != 0)
                return pA / pB;
            else
                throw new DivideByZeroException("No se puede dividir entre cero.");
        }
    }
}
