using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class SaborChocolate:IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }

        public string informacion()
        {
            return "Sabor chocolate";
        }
    }
}
