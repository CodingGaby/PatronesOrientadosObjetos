using System;

namespace DocProcessor
{
    /// Esta clase es una fábrica para instanciar procesadores de documentos.
    /// Autor: Jorge Gabriel Garcia Osorio
    /// Fecha: 29/11/2024
    /// Versión: 1.0.0.0
    /// Modificación: 29/11/2024
    public class DocumentProcessorFactory
    {
        /// Crea un procesador de documentos basado en el tipo de documento.
        /// Autor: Jorge Gabriel Garcia Osorio
        /// Fecha: 29/11/2024
        /// Versión: 1.0.0.0
        /// Modificación: 29/11/2024
        /// <param name="documentType">Tipo de documento</param>
        /// <returns>Instancia del procesador correspondiente</returns>
        public static DocumentProcessor CreateProcessor(string documentType)
        {
            if (documentType.ToLower() == "pdf")
            {
                return new PDFProcessor();
            }
            else if (documentType.ToLower() == "word")
            {
                return new WordProcessor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("Tipo de documento no soportado.");
            }
        }
    }
}
