using System;

namespace Adaptador06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es el cliente

            int resultado = 0;

            // Usamos la interfaz que el cliente conoce con una clase que conoce
            ITarget calcu = new CCalcu();

            // Operaciones directas
            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado de la suma es {0}", resultado);

            resultado = calcu.Restar(9, 5);
            Console.WriteLine("El resultado de la resta es {0}", resultado);

            resultado = calcu.Multiplicar(2, 6);
            Console.WriteLine("El resultado de la multiplicación es {0}", resultado);

            resultado = calcu.Dividir(8, 2);
            Console.WriteLine("El resultado de la división es {0}", resultado);

            Console.WriteLine("-----------------");

            // Hacemos uso del adaptador
            calcu = new CAdaptador();

            // Usamos el adaptador para hacer las operaciones
            resultado = calcu.Sumar(5, 6);
            Console.WriteLine("El resultado de la suma es {0}", resultado);

            resultado = calcu.Restar(9, 3);
            Console.WriteLine("El resultado de la resta es {0}", resultado);

            resultado = calcu.Multiplicar(3, 3);
            Console.WriteLine("El resultado de la multiplicación es {0}", resultado);

            resultado = calcu.Dividir(10, 2);
            Console.WriteLine("El resultado de la división es {0}", resultado);

            Console.ReadKey();
        }
    }
}
