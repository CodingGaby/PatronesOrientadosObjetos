using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    internal class ComandoPrenderDRS: IComando
    {
        AutoFormula autoF;

        public ComandoPrenderDRS(AutoFormula pAuto)
        {
            autoF = pAuto;
        }

        public void ejecutar()
        {
            autoF.ActivarDRS();
        }
    }
}
