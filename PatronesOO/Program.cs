using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            double carrito = 0;
            double res = 0;

            IEnvio envio = new CNormal();

            while (opc != 5) 
            {
                Console.WriteLine("\nQue tipo de envio deseas usar? \n 1.-Normal \n 2.-Internacional \n 3.-Express \n 4.-InterExpress \n\t 5.-Salir");
                opc = int.Parse(Console.ReadLine());

                Console.WriteLine("Cual es el costo de tu carrito?");
                carrito = double.Parse(Console.ReadLine());

                switch(opc)
                {
                    case 2:
                        envio = new CInternacional();
                        break;
                    case 3:
                        envio = new CExpress();
                        break;
                    case 4:
                        envio = new CInterExpress();
                        break;
                    default:
                        envio = new CNormal();
                        break;
                }

                res = envio.obtenerCosto(carrito);

                Console.WriteLine("El costo con envio de tu pedidio seria {0}", res);
            }
        }
    }
}
