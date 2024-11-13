namespace Comando16
{
    class ComandoEncender : IComando
    {
        Automovil auto;
        AutoFormula autoF;

        public ComandoEncender(Automovil pAuto)
        {
            auto = pAuto;
            autoF = null;
        }

        public ComandoEncender(AutoFormula pAuto)
        {
            autoF = pAuto;
            auto = null;
        }

        public void ejecutar()
        {
            if (autoF != null) autoF.Encender();
            if (auto != null) auto.Encender();
        }
    }
}