using System;

namespace Comando16
{
    class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ha encendido el auto");
        }

        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ha apagado el auto");
        }

        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma encendida");
        }

        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma apagada");
        }
    }
}