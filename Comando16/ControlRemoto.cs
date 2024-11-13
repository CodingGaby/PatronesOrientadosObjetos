using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    class ControlRemoto
    {
        private IComando[] comandos = new IComando[4];

        public ControlRemoto(Automovil pAuto) 
        {
            comandos[0] = new ComandoEncender(pAuto);
            comandos[1] = new ComandoApagar(pAuto);
            comandos[2] = new ComandoPrenderAlarma(pAuto);
            comandos[3] = new ComandoApagarAlarma(pAuto);
        }

        public ControlRemoto(AutoFormula pAuto)
        {
            comandos[0] = new ComandoEncender(pAuto);
            comandos[1] = new ComandoApagar(pAuto);
            comandos[2] = new ComandoPrenderDRS(pAuto);
            comandos[3] = new ComandoApagarDRS(pAuto);
        }

        public ControlRemoto(Automovil pAuto, AutoFormula pAutoF)
        {
            comandos[0] = new ComandoEncenderAmbos(pAuto, pAutoF);
            comandos[1] = new ComandoApagarAmbos(pAuto, pAutoF);
        }

        public void Boton(int pIndice)
        {
            comandos[pIndice].ejecutar();
        }
    }
}
