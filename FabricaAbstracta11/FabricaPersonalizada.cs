using System;

namespace FabricaAbstracta11
{
    class FabricaPersonalizada : IFabrica
    {
        // Aquí guardamos la única instancia que existirá.
        private static FabricaPersonalizada instancia;

        // Campos privados para los productos.
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        // Constructor privado para evitar instanciación directa.
        private FabricaPersonalizada() { }

        // Método para obtener la única instancia de la fábrica.
        public static FabricaPersonalizada ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FabricaPersonalizada();
                Console.WriteLine("--- Instancia de FabricaPersonalizada creada por primera vez ---");
            }
            return instancia;
        }

        // Implementación de los métodos de la interfaz IFabrica.
        public IProductoLeche obtenerProductoLeche { get { return leche; } }
        public IProductoSaborizante obtenerSabor { get { return sabor; } }

        public void crearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Selecciona la leche:");
            Console.WriteLine("1) Almendra");
            Console.WriteLine("2) Coco");
            Console.WriteLine("3) Vaca");
            string seleccionLeche = Console.ReadLine();

            switch (seleccionLeche)
            {
                case "1":
                    leche = new LecheAlmendras();
                    break;
                case "2":
                    leche = new LecheCoco();
                    break;
                case "3":
                    leche = new LecheVaca();
                    break;
                default:
                    Console.WriteLine("Opción no válida, se usará leche de vaca por defecto.");
                    leche = new LecheVaca();
                    break;
            }

            leche.producir();

            Console.WriteLine("\nSelecciona el sabor:");
            Console.WriteLine("1) Vainilla Natural");
            Console.WriteLine("2) Chocolate");
            string seleccionSabor = Console.ReadLine();

            switch (seleccionSabor)
            {
                case "1":
                    sabor = new VainillaNatural();
                    break;
                case "2":
                    sabor = new SaborChocolate();
                    break;
                default:
                    Console.WriteLine("Opción no válida, se usará sabor chocolate por defecto.");
                    sabor = new SaborChocolate();
                    break;
            }

            sabor.obtener();
        }
    }
}
