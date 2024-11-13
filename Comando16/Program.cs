using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de auto 1.-Formula 2.-Auto 3.-Ambos");
            string op = Console.ReadLine();

            if (op == "2")
            {
                Automovil miAuto = new Automovil();

                ControlRemoto control = new ControlRemoto(miAuto);
                string opc;

                do
                {
                    Console.WriteLine("1-Encender \n 2-Apagar \n 3-Prender Alarma \n 4-Apagar Alarma \n 5-Salir");

                    opc = Console.ReadLine();

                    if (opc == "1")
                        control.Boton(0);
                    if (opc == "2")
                        control.Boton(1);
                    if (opc == "3")
                        control.Boton(2);
                    if (opc == "4")
                        control.Boton(3);

                } while (opc != "5");
            } 
            else if(op == "1")
            {
                AutoFormula miAuto = new AutoFormula();

                ControlRemoto control = new ControlRemoto(miAuto);
                string opc;

                do
                {
                    Console.WriteLine("1-Encender \n 2-Apagar \n 3-Prender DRS \n 4-Apagar DRS \n 5-Salir");

                    opc = Console.ReadLine();

                    if (opc == "1")
                        control.Boton(0);
                    if (opc == "2")
                        control.Boton(1);
                    if (opc == "3")
                        control.Boton(2);
                    if (opc == "4")
                        control.Boton(3);

                } while (opc != "5");
            }
            else
            {
                AutoFormula miAutoF = new AutoFormula();
                Automovil miAuto = new Automovil();

                ControlRemoto control = new ControlRemoto(miAuto, miAutoF);
                string opc;

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1-Encender ambos\n2-Apagar ambos \n3-Salir");

                    opc = Console.ReadLine();

                    if (opc == "1")
                        control.Boton(0);
                    if (opc == "2")
                        control.Boton(1);


                } while (opc != "3");
            }
            
        }
    }
}
