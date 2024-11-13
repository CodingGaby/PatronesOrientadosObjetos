using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    class AutoFormula
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Se ha encendido el Formula");
        }

        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Se ha apagado el Formula");
        }

        public void ActivarDRS()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DRS Activado");
        }

        public void QuitarDRS()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DRS apagado");
        }
    }
}
