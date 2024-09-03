using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main representa al cliente

            string[] pasajeros = new string[7];
            string[] categorias = { "Premium", "PC", "Turista" };

            Random random = new Random();

            for (int i = 0; i < pasajeros.Length; i++)
            {
                int categoriaIndex = random.Next(categorias.Length);
                pasajeros[i] = categorias[categoriaIndex];
            }

            // Creamos el bridge

            CAbstraccion bridge = new CAbstraccion(new CImplementacion1(), pasajeros);

            //CAbstraccion bridge = new CAbstraccion(3  , productos);

            bridge.MostrarAlimentos();

            Console.ReadKey();
        }
    }
}
