using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptador06
{
    class CCalculadoraArray
    {
        // Esta es la clase que deseamos adaptar, el cliente no la puede usar directamente
        // pues su interfaz es diferente

        public double suma(int[] pOperandos)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;
        }
    }
}
