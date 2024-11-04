using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    interface IFabrica
    {
        void crearProductos();
        IProductoLeche obtenerProductoLeche { get; }
        IProductoSaborizante obtenerSabor {  get; }
    }
}
