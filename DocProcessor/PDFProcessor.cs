using System;

namespace DocProcessor
{
    /// Procesador concreto para documentos PDF.
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 29/11/2024
    /// Versión: 1.0.0.0
    /// Modificación: 29/11/2024
    public class PDFProcessor : DocumentProcessor
    {
        protected override void LoadDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cargando documento PDF...");
        }

        protected override void ParseDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Analizando contenido del PDF...");
        }

        protected override void SaveDocument()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Guardando cambios en el PDF...");
        }
    }
}
