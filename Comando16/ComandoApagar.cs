namespace Comando16
{
    internal class ComandoApagar : IComando
    {
        Automovil auto;

        AutoFormula autoF;

        public ComandoApagar(Automovil pAuto)
        {
            auto = pAuto;
            autoF = null;
        }

        public ComandoApagar(AutoFormula pAuto)
        {
            autoF = pAuto;
            auto = null;
        }

        public void ejecutar()
        {
            if (autoF != null) autoF.Apagar();
            if (auto != null) auto.Apagar();
        }
    }
}