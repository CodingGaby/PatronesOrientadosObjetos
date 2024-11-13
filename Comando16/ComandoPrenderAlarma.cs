﻿namespace Comando16
{
    class ComandoPrenderAlarma : IComando
    {
        Automovil auto;

        public ComandoPrenderAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            // Invocamos la accion correspondiente en el auto
            auto.ColocarAlarma();
        }
    }
}