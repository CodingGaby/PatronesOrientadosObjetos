using System;
using System.IO;

namespace DocProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opc = "1";

            while (opc != "2")
            {
                var controller = ProcessingController.GetInstance();

                // Obtener el tipo de archivo
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Introduce el tipo de documento (pdf/word):");
                string documentType = Console.ReadLine();

                //Obtener la ruta del archivo
                Console.WriteLine("Introduce la ruta del archivo (Ruta falsa):");
                string filePath = Console.ReadLine();


                if (filePath != null)
                {
                    try
                    {
                        var processor = DocumentProcessorFactory.CreateProcessor(documentType);
                        controller.ProcessDocument(processor);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nQuieres procesar otro archivo? 1.Si 2.No");
                opc = Console.ReadLine();
            }
        }
    }
}
