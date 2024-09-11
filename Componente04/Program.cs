using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente04
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new CCompuesto<string>("Root");
            IComponente<string> trabajo = arbol;

            string opcion = "";
            string dato = "";

            while (opcion != "6") 
            {
                Console.WriteLine("Estoy en {0}", trabajo.Nombre);
                Console.WriteLine("1.-Adicionar Compuesto 2.- Adicionanr componente 3.-Borrar 4.-Buscar 5.-Mostrar 6.-Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("---------------");

                if (opcion == "1") 
                {
                    Console.WriteLine("Dame el nombre del compuesto");
                    dato = Console.ReadLine();

                    IComponente<string> c = new CCompuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new CComponente<string>(dato));
                }
                if (opcion == "3")
                {
                    Console.WriteLine("Dame el nombre del elemento a borrar: ");
                    dato = Console.ReadLine();

                    trabajo.Borrar(dato);
                }

                if (opcion == "4")
                {
                    Console.WriteLine("Dame el nombre del elemento a buscar: ");
                    dato = Console.ReadLine();

                    trabajo = arbol.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(arbol.Mostrar(0));
                }
            }

            Console.ReadKey();
        }
    }
}
