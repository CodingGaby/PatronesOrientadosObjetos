using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton10
{
    class Program
    {
        static void Main(string[] args)
        {
            // No se puede obtener la instancia directamente
            //CSingleton uno = new CSingleton();

            // Obtenemos la instancia, se crea por primera vez
            CSingleton uno = CSingleton.ObtenerInstancia();

            // Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("---------");

            // Obtenemos la instancia
            CSingleton dos = CSingleton.ObtenerInstancia();
            // Comprobamos que es la misma instancia
            // Si lo es, tendra el mismo estado
            Console.WriteLine(dos);

            Console.ReadKey();
        }
    }
}
