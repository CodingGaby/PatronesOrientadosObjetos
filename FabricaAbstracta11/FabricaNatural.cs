using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaAbstracta11
{
    class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche obtenerProductoLeche { get { return leche;} }

        public IProductoSaborizante obtenerSabor { get {  return sabor;} }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) almendras 2) Coco");

            seleccion = Console.ReadLine();

            if (seleccion == "1")
                leche = new LecheAlmendras();
            else
                leche = new LecheCoco();

            leche.producir();

            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new VainillaNatural();
            sabor.obtener();
        }
    }
}
