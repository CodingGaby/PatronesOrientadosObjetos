using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    class ComandoApagarDRS: IComando
    {
        AutoFormula autoF;

        public ComandoApagarDRS(AutoFormula pAuto)
        {
            autoF = pAuto;
        }

        public void ejecutar()
        {
            autoF.QuitarDRS();
        }
    }
}
