using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    internal class LecheCoco:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }

        public string obtenDatos()
        {
            return "Leche de coco natural, 250ml";
        }
    }
}
