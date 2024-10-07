using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el administrador
            CAdminPrototipos admin = new CAdminPrototipos();

            // Obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenerPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenerPrototipo("Persona");

            // Verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("------------");

            // Modificamos el estado
            uno.Nombre = "Ana";
            dos.Nombre = "Chepe";

            // Verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("------------");

            // Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            // Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            // Obtenemos un objeto de este prototipo
            CAuto auto2 = (CAuto)admin.ObtenerPrototipo("Auto");

            // Cambiamos el estado
            auto2.Modelo = "Honda";

            // Verificamos que cada uno tenga su estado
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("------------");

            Console.ReadKey();
        }
    }
}
