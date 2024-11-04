using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class LecheAlmendras:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string obtenDatos()
        {
            return "Leche organica de almendra, 250ml";
        }
    }
}
