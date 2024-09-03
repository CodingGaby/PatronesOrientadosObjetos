using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge04
{
    //Esta es la interface que las implementaciones deben mostrar
    interface IBridge
    {
        void MostrarAlimentos(string[] pPasajeros);
    }
}
