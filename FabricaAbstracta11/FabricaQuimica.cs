using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class FabricaQuimica:IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche obtenerProductoLeche { get { return leche; } }

        public IProductoSaborizante obtenerSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
