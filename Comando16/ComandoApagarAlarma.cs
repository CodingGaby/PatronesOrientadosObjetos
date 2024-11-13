namespace Comando16
{
    class ComandoApagarAlarma : IComando
    {

        Automovil auto;

        public ComandoApagarAlarma(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            // Invocamos la accion correspondiente en el auto
            auto.QuitarAlarma();
        }
    }
}