namespace Comando16
{
    internal class ComandoApagarAmbos : IComando
    {
        Automovil auto;
        AutoFormula autoF;

        public ComandoApagarAmbos(Automovil pAuto, AutoFormula pAutoF)
        {
            auto = pAuto;
            autoF = pAutoF;
        }

        public void ejecutar()
        {
            autoF.Apagar();
            auto.Apagar();
        }
    }
}