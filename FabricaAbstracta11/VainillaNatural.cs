using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class VainillaNatural:IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }

        public string informacion()
        {
            return "Extracto natural de vainilla";
        }
    }
}
