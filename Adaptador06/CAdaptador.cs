using System;

namespace Adaptador06
{
    class CAdaptador : ITarget
    {
        CCalculadoraArray adaptado = new CCalculadoraArray();

        // Adaptación de las operaciones

        public int Sumar(int pA, int pB)
        {
            int[] operadores = { pA, pB };
            return (int)adaptado.suma(operadores);
        }

        public int Restar(int pA, int pB)
        {
            int[] operadores = { pA, -pB }; // Usamos -pB para restar
            return (int)adaptado.suma(operadores);
        }

        public int Multiplicar(int pA, int pB)
        {
            return pA * pB; // Directamente
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
