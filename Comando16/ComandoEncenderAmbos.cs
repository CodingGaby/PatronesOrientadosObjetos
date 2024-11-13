using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    class ComandoEncenderAmbos : IComando 
    {
        Automovil auto;
        AutoFormula autoF;

        public ComandoEncenderAmbos(Automovil pAuto, AutoFormula pAutoF)
        {
            auto = pAuto;
            autoF = pAutoF;
        }

        public void ejecutar()
        {
            autoF.Encender();
            auto.Encender();
        }
    }
}
