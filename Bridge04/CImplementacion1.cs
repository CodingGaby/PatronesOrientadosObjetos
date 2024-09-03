using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge04
{
    class CImplementacion1 : IBridge
    {
        public void MostrarAlimentos(string[] pPasajeros)
        {
            int cantidad = 0;

            foreach (string p in pPasajeros)
            {
                if (p.Equals("PC"))
                    Console.WriteLine("El pasajero {0} come salmon", p.IndexOf(p));
                if (p.Equals("Premium"))
                    Console.WriteLine("El pasajero come atun");
                if (p.Equals("Turista"))
                    Console.WriteLine("El pasajero come salmon");

                cantidad++;
            }

            Console.WriteLine("El total de pasajetos es {0}", cantidad);
        }
    }
}
