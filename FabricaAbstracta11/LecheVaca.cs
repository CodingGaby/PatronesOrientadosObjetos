using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class LecheVaca : IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Ordeniar vaca en la granja");
        }

        public string obtenDatos()
        {
            return "Leche vaca, 250ml";
        }
    }
}
