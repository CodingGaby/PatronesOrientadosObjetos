using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge04
{
    class CAbstraccion
    {
        IBridge implementacion;
        string[] pasajeros;

        public CAbstraccion(IBridge pImp, string[] pPsj)
        {
            implementacion = pImp;
            pasajeros = pPsj;
        }

        public void MostrarAlimentos()
        {
            implementacion.MostrarAlimentos(pasajeros);
        }
    }
}
